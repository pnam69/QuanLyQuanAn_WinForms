using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;
using QRCoder;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmThanhToan : Form
    {
        private readonly int maDon;
        public FrmThanhToan(int maDon)
        {
            InitializeComponent();
            this.maDon = maDon;
            LoadPhuongThuc();
            LoadThongTinThanhToan();
        }

        private void LoadPhuongThuc()
        {
            cboPhuongThuc.Items.Clear();

            cboPhuongThuc.Items.Add("Tiền mặt");
            cboPhuongThuc.Items.Add("Chuyển khoản");
            cboPhuongThuc.Items.Add("MoMo");

            cboPhuongThuc.SelectedIndex = 0;
        }

        private async void LoadThongTinThanhToan()
        {
            using var db = DbContextFactory.Create();

            var donHang = await db.DonHangs
                .AsNoTracking()
                .Include(x => x.Ban)
                .FirstOrDefaultAsync(x => x.MaDon == maDon);

            if (donHang == null)
            {
                MessageBox.Show(
                    "Không tìm thấy đơn hàng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                Close();
                return;
            }

            lblMaDon.Text = $"Mã đơn: {donHang.MaDon}";

            lblBan.Text = donHang.Ban != null
                ? $"Bàn: {donHang.Ban.SoBan}"
                : "Bàn: Không xác định";

            lblTongTien.Text =
                $"Tổng tiền: {donHang.TongTien:N0} đ";

            var chiTiet = await db.ChiTietDonHangs
                .AsNoTracking()
                .Where(x => x.MaDon == maDon)
                .Include(x => x.MonAn)
                .OrderBy(x => x.MaChiTiet)
                .Select(x => new
                {
                    MaChiTiet = x.MaChiTiet,
                    TenMon = x.MonAn != null
                        ? x.MonAn.TenMon
                        : "",
                    DonGia = x.DonGia,
                    SoLuong = x.SoLuong,
                    ThanhTien = x.ThanhTien
                })
                .ToListAsync();

            dgvChiTietThanhToan.DataSource = chiTiet;

            DatTenCot();

            if (donHang.TrangThai == "Đã thanh toán")
            {
                btnThanhToan.Enabled = false;
                cboPhuongThuc.Enabled = false;

                MessageBox.Show(
                    "Đơn hàng này đã được thanh toán.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            CapNhatQRCode();
        }

        private void DatTenCot()
        {
            if (dgvChiTietThanhToan.Columns["MaChiTiet"] != null)
            {
                dgvChiTietThanhToan.Columns["MaChiTiet"].HeaderText =
                    "Mã chi tiết";

                dgvChiTietThanhToan.Columns["MaChiTiet"].Visible = false;
            }

            if (dgvChiTietThanhToan.Columns["TenMon"] != null)
            {
                dgvChiTietThanhToan.Columns["TenMon"].HeaderText =
                    "Món ăn";
            }

            if (dgvChiTietThanhToan.Columns["DonGia"] != null)
            {
                dgvChiTietThanhToan.Columns["DonGia"].HeaderText =
                    "Đơn giá";

                dgvChiTietThanhToan.Columns["DonGia"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvChiTietThanhToan.Columns["SoLuong"] != null)
            {
                dgvChiTietThanhToan.Columns["SoLuong"].HeaderText =
                    "Số lượng";
            }

            if (dgvChiTietThanhToan.Columns["ThanhTien"] != null)
            {
                dgvChiTietThanhToan.Columns["ThanhTien"].HeaderText =
                    "Thành tiền";

                dgvChiTietThanhToan.Columns["ThanhTien"]
                    .DefaultCellStyle.Format = "N0";
            }
        }

        private void CapNhatQRCode()
        {
            if (cboPhuongThuc.SelectedItem == null)
            {
                return;
            }

            string phuongThuc =
                cboPhuongThuc.SelectedItem.ToString()!;

            if (phuongThuc == "Tiền mặt")
            {
                picQRCode.Image?.Dispose();
                picQRCode.Image = null;

                lblNoiDungQR.Text =
                    "Thanh toán bằng tiền mặt.";

                return;
            }

            using var db = DbContextFactory.Create();

            var donHang = db.DonHangs
                .AsNoTracking()
                .FirstOrDefault(x => x.MaDon == maDon);

            if (donHang == null)
            {
                return;
            }

            string noiDung =
                $"QUAN LY QUAN AN|DON #{donHang.MaDon}|SO TIEN {donHang.TongTien:0}|{phuongThuc}";

            GenerateQRCode(noiDung);

            lblNoiDungQR.Text =
                $"Quét mã QR để thanh toán\n" +
                $"Phương thức: {phuongThuc}\n" +
                $"Số tiền: {donHang.TongTien:N0} đ";
        }

        private void GenerateQRCode(string noiDung)
        {
            try
            {
                using QRCodeGenerator qrGenerator =
                    new QRCodeGenerator();

                using QRCodeData qrCodeData =
                    qrGenerator.CreateQrCode(
                        noiDung,
                        QRCodeGenerator.ECCLevel.Q);

                PngByteQRCode qrCode =
                    new PngByteQRCode(qrCodeData);

                byte[] qrBytes =
                    qrCode.GetGraphic(10);

                using var stream =
                    new MemoryStream(qrBytes);

                Image newImage =
                    Image.FromStream(stream);

                picQRCode.Image?.Dispose();

                picQRCode.Image = new Bitmap(newImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không thể tạo mã QR.\n\n{ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cboPhuongThuc.SelectedItem == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn phương thức thanh toán.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string phuongThuc =
                cboPhuongThuc.SelectedItem.ToString()!;

            using var db = DbContextFactory.Create();

            var donHang = await db.DonHangs
                .Include(x => x.Ban)
                .FirstOrDefaultAsync(x => x.MaDon == maDon);

            if (donHang == null)
            {
                MessageBox.Show(
                    "Không tìm thấy đơn hàng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (donHang.TrangThai == "Đã thanh toán")
            {
                MessageBox.Show(
                    "Đơn hàng này đã được thanh toán.",
                    "Không thể thực hiện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool daThanhToan = await db.ThanhToans
                .AnyAsync(x => x.MaDon == maDon);

            if (daThanhToan)
            {
                MessageBox.Show(
                    "Đơn hàng đã có thông tin thanh toán.",
                    "Không thể thực hiện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int soLuongMon = await db.ChiTietDonHangs
                .Where(x => x.MaDon == maDon)
                .SumAsync(x => x.SoLuong);

            if (soLuongMon <= 0)
            {
                MessageBox.Show(
                    "Đơn hàng chưa có món ăn. Không thể thanh toán.",
                    "Không thể thực hiện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal tongTien = await db.ChiTietDonHangs
                .Where(x => x.MaDon == maDon)
                .SumAsync(x => (decimal?)x.ThanhTien) ?? 0;

            if (tongTien <= 0)
            {
                MessageBox.Show(
                    "Tổng tiền đơn hàng không hợp lệ.",
                    "Không thể thực hiện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var confirm = MessageBox.Show(
                $"Xác nhận thanh toán đơn #{maDon}?\n\n" +
                $"Số tiền: {tongTien:N0} đ\n" +
                $"Phương thức: {phuongThuc}",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            var thanhToan = new Models.ThanhToan
            {
                MaDon = maDon,
                SoTien = tongTien,
                NgayThanhToan = DateTime.Now,
                PhuongThuc = phuongThuc,
                TrangThai = "Đã thanh toán"
            };

            db.ThanhToans.Add(thanhToan);

            donHang.TongTien = tongTien;
            donHang.TrangThai = "Đã thanh toán";

            if (donHang.Ban != null)
            {
                donHang.Ban.TrangThai = "Trống";
            }

            await db.SaveChangesAsync();

            MessageBox.Show(
                $"Thanh toán thành công!\n\n" +
                $"Mã đơn: {maDon}\n" +
                $"Số tiền: {tongTien:N0} đ\n" +
                $"Phương thức: {phuongThuc}",
                "Thanh toán thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            picQRCode.Image?.Dispose();
            picQRCode.Image = null;

            base.OnFormClosed(e);
        }

        private void cboPhuongThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatQRCode();
        }
    }
}
