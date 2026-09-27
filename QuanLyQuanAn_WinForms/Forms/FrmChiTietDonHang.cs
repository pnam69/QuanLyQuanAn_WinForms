using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;


namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmChiTietDonHang : Form
    {

        private readonly int maDon;
        private int maChiTiet = 0;

        public FrmChiTietDonHang(int maDon)
        {
            InitializeComponent();
            this.maDon = maDon;
            lblMaDon.Text = $"Mã đơn: {maDon}";

            LoadMonAn();
            LoadChiTiet();
        }

        private async void LoadMonAn()
        {
            using var db = DbContextFactory.Create();

            var danhSach = await db.MonAns
                .AsNoTracking()
                .Where(x => x.TrangThai == "Đang bán")
                .OrderBy(x => x.TenMon)
                .ToListAsync();

            cboMonAn.DataSource = danhSach;
            cboMonAn.DisplayMember = "TenMon";
            cboMonAn.ValueMember = "MaMon";
        }

        private async void LoadChiTiet()
        {
            using var db = DbContextFactory.Create();

            var danhSach = await db.ChiTietDonHangs
                .AsNoTracking()
                .Where(x => x.MaDon == maDon)
                .Include(x => x.MonAn)
                .OrderBy(x => x.MaChiTiet)
                .Select(x => new
                {
                    x.MaChiTiet,
                    MaMon = x.MaMon,
                    TenMon = x.MonAn != null
                        ? x.MonAn.TenMon
                        : "",
                    x.DonGia,
                    x.SoLuong,
                    x.ThanhTien
                })
                .ToListAsync();

            dgvChiTiet.DataSource = danhSach;

            CapNhatTongTien();
        }

        private async void CapNhatTongTien()
        {
            using var db = DbContextFactory.Create();

            decimal tongTien = await db.ChiTietDonHangs
                .Where(x => x.MaDon == maDon)
                .SumAsync(x => (decimal?)x.ThanhTien) ?? 0;

            lblTongTien.Text =
                $"Tổng tiền: {tongTien:N0} đ";
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (cboMonAn.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn món ăn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int maMon =
                Convert.ToInt32(cboMonAn.SelectedValue);

            int soLuong =
                Convert.ToInt32(numSoLuong.Value);

            using var db = DbContextFactory.Create();

            var donHang = await db.DonHangs
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
                    "Không thể thêm món vào đơn đã thanh toán.",
                    "Không thể thực hiện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var monAn = await db.MonAns
                .FirstOrDefaultAsync(x =>
                    x.MaMon == maMon &&
                    x.TrangThai == "Đang bán");

            if (monAn == null)
            {
                MessageBox.Show(
                    "Món ăn không tồn tại hoặc đã ngừng bán.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var chiTiet = await db.ChiTietDonHangs
                .FirstOrDefaultAsync(x =>
                    x.MaDon == maDon &&
                    x.MaMon == maMon);

            if (chiTiet != null)
            {
                chiTiet.SoLuong += soLuong;
                chiTiet.ThanhTien =
                    chiTiet.SoLuong * chiTiet.DonGia;
            }
            else
            {
                chiTiet = new ChiTietDonHang
                {
                    MaDon = maDon,
                    MaMon = maMon,
                    SoLuong = soLuong,
                    DonGia = monAn.DonGia,
                    ThanhTien = monAn.DonGia * soLuong
                };

                db.ChiTietDonHangs.Add(chiTiet);
            }

            await db.SaveChangesAsync();

            await CapNhatTongTienVaDonHang(db);

            ClearSelection();
            LoadChiTiet();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (maChiTiet == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn món cần cập nhật.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int soLuong =
                Convert.ToInt32(numSoLuong.Value);

            using var db = DbContextFactory.Create();

            var donHang = await db.DonHangs
                .FirstOrDefaultAsync(x => x.MaDon == maDon);

            if (donHang == null)
            {
                return;
            }

            if (donHang.TrangThai == "Đã thanh toán")
            {
                MessageBox.Show(
                    "Không thể sửa đơn đã thanh toán.",
                    "Không thể thực hiện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var chiTiet = await db.ChiTietDonHangs
                .FirstOrDefaultAsync(x =>
                    x.MaChiTiet == maChiTiet &&
                    x.MaDon == maDon);

            if (chiTiet == null)
            {
                return;
            }

            chiTiet.SoLuong = soLuong;
            chiTiet.ThanhTien =
                chiTiet.DonGia * soLuong;

            await db.SaveChangesAsync();

            await CapNhatTongTienVaDonHang(db);

            ClearSelection();
            LoadChiTiet();
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (maChiTiet == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn món cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa món này khỏi đơn hàng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            using var db = DbContextFactory.Create();

            var donHang = await db.DonHangs
                .FirstOrDefaultAsync(x => x.MaDon == maDon);

            if (donHang == null)
            {
                return;
            }

            if (donHang.TrangThai == "Đã thanh toán")
            {
                MessageBox.Show(
                    "Không thể sửa đơn đã thanh toán.",
                    "Không thể thực hiện",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var chiTiet = await db.ChiTietDonHangs
                .FirstOrDefaultAsync(x =>
                    x.MaChiTiet == maChiTiet &&
                    x.MaDon == maDon);

            if (chiTiet == null)
            {
                return;
            }

            db.ChiTietDonHangs.Remove(chiTiet);

            await db.SaveChangesAsync();

            await CapNhatTongTienVaDonHang(db);

            ClearSelection();
            LoadChiTiet();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            using var frm = new FrmThanhToan(maDon);
            frm.ShowDialog();

            LoadChiTiet();
        }

        private async Task CapNhatTongTienVaDonHang(
            AppDbContext db)
        {
            decimal tongTien = await db.ChiTietDonHangs
                .Where(x => x.MaDon == maDon)
                .SumAsync(x => (decimal?)x.ThanhTien) ?? 0;

            var donHang = await db.DonHangs
                .FirstOrDefaultAsync(x => x.MaDon == maDon);

            if (donHang != null)
            {
                donHang.TongTien = tongTien;
                await db.SaveChangesAsync();
            }
        }

        private void ClearSelection()
        {
            maChiTiet = 0;
            numSoLuong.Value = 1;
            dgvChiTiet.ClearSelection();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = dgvChiTiet.Rows[e.RowIndex];

            maChiTiet =
                Convert.ToInt32(row.Cells["MaChiTiet"].Value);

            int maMon =
                Convert.ToInt32(row.Cells["MaMon"].Value);

            int soLuong =
                Convert.ToInt32(row.Cells["SoLuong"].Value);

            cboMonAn.SelectedValue = maMon;
            numSoLuong.Value = soLuong;
        }
    }
}
