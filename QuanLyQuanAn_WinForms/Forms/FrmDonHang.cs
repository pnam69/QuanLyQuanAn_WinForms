using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmDonHang : Form
    {
        private int maDon = 0;

        public FrmDonHang()
        {
            InitializeComponent();

            LoadTrangThai();
            LoadBan();
            LoadNhanVien();
            LoadDonHang();

            dgvDonHang.CellClick += dgvDonHang_CellClick;
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Tất cả");
            cboTrangThai.Items.Add("Đang phục vụ");
            cboTrangThai.Items.Add("Đã thanh toán");

            cboTrangThai.SelectedIndex = 0;

            cboTrangThai.SelectedIndexChanged +=
                cboTrangThai_SelectedIndexChanged;
        }

        private async void LoadBan()
        {
            using var db = DbContextFactory.Create();

            var danhSach = await db.Bans
                .AsNoTracking()
                .OrderBy(x => x.SoBan)
                .ToListAsync();

            cboBan.DataSource = danhSach;
            cboBan.DisplayMember = "SoBan";
            cboBan.ValueMember = "MaBan";
        }

        private async void LoadNhanVien()
        {
            using var db = DbContextFactory.Create();

            var danhSach = await db.NhanViens
                .AsNoTracking()
                .Where(x => x.TrangThai == "Hoạt động")
                .OrderBy(x => x.HoTen)
                .ToListAsync();

            cboNhanVien.DataSource = danhSach;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";
        }

        private async void LoadDonHang()
        {
            using var db = DbContextFactory.Create();

            var query = db.DonHangs
                .AsNoTracking()
                .Include(x => x.Ban)
                .Include(x => x.NhanVien)
                .AsQueryable();

            if (cboTrangThai.SelectedIndex > 0)
            {
                string trangThai = cboTrangThai.Text;

                query = query.Where(x =>
                    x.TrangThai == trangThai);
            }

            var danhSach = await query
                .OrderByDescending(x => x.MaDon)
                .Select(x => new
                {
                    x.MaDon,
                    SoBan = x.Ban != null
                        ? x.Ban.SoBan
                        : "",
                    NhanVien = x.NhanVien != null
                        ? x.NhanVien.HoTen
                        : "",
                    x.NgayLap,
                    x.TongTien,
                    x.TrangThai
                })
                .ToListAsync();

            dgvDonHang.DataSource = danhSach;
        }

        private void dgvDonHang_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = dgvDonHang.Rows[e.RowIndex];

            maDon = Convert.ToInt32(
                row.Cells["MaDon"].Value);

            string soBan =
    row.Cells["SoBan"].Value?.ToString() ?? "";

            string nhanVien =
                row.Cells["NhanVien"].Value?.ToString() ?? "";

            if (cboBan.Items.Count > 0)
            {
                for (int i = 0; i < cboBan.Items.Count; i++)
                {
                    var ban = (Ban)cboBan.Items[i];

                    if (ban.SoBan == soBan)
                    {
                        cboBan.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (cboNhanVien.Items.Count > 0)
            {
                for (int i = 0; i < cboNhanVien.Items.Count; i++)
                {
                    var itemNhanVien = (NhanVien)cboNhanVien.Items[i];

                    if (itemNhanVien.HoTen == nhanVien)
                    {
                        cboNhanVien.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (cboBan.SelectedValue == null ||
                cboNhanVien.SelectedValue == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn bàn và nhân viên.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int maBan =
                Convert.ToInt32(cboBan.SelectedValue);

            int maNV =
                Convert.ToInt32(cboNhanVien.SelectedValue);

            using var db = DbContextFactory.Create();

            var ban = await db.Bans
                .FirstOrDefaultAsync(x => x.MaBan == maBan);

            if (ban == null)
            {
                MessageBox.Show(
                    "Không tìm thấy bàn.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (ban.TrangThai == "Đang phục vụ")
            {
                MessageBox.Show(
                    "Bàn này đang có đơn hàng.",
                    "Không thể tạo đơn",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var donHang = new DonHang
            {
                MaBan = maBan,
                MaNV = maNV,
                NgayLap = DateTime.Now,
                TongTien = 0,
                TrangThai = "Đang phục vụ"
            };

            db.DonHangs.Add(donHang);

            ban.TrangThai = "Đang phục vụ";

            await db.SaveChangesAsync();

            MessageBox.Show(
                "Tạo đơn hàng thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            maDon = donHang.MaDon;

            LoadDonHang();
            LoadBan();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (maDon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn hàng cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

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
                    "Không thể sửa đơn hàng đã thanh toán.",
                    "Không thể sửa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboBan.SelectedValue == null ||
                cboNhanVien.SelectedValue == null)
            {
                return;
            }

            int maBan =
                Convert.ToInt32(cboBan.SelectedValue);

            int maNV =
                Convert.ToInt32(cboNhanVien.SelectedValue);

            if (donHang.MaBan != maBan)
            {
                var banMoi = await db.Bans
                    .FirstOrDefaultAsync(x => x.MaBan == maBan);

                if (banMoi == null)
                {
                    return;
                }

                if (banMoi.TrangThai == "Đang phục vụ")
                {
                    MessageBox.Show(
                        "Bàn mới đang có đơn hàng.",
                        "Không thể đổi bàn",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var banCu = await db.Bans
                    .FirstOrDefaultAsync(x =>
                        x.MaBan == donHang.MaBan);

                if (banCu != null)
                {
                    banCu.TrangThai = "Trống";
                }

                banMoi.TrangThai = "Đang phục vụ";

                donHang.MaBan = maBan;
            }

            donHang.MaNV = maNV;

            await db.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật đơn hàng thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadDonHang();
            LoadBan();
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (maDon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn hàng cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa đơn hàng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            using var db = DbContextFactory.Create();

            var donHang = await db.DonHangs
                .Include(x => x.ThanhToan)
                .FirstOrDefaultAsync(x => x.MaDon == maDon);

            if (donHang == null)
            {
                return;
            }

            if (donHang.TrangThai == "Đã thanh toán")
            {
                MessageBox.Show(
                    "Không thể xóa đơn hàng đã thanh toán.",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var ban = await db.Bans
                .FirstOrDefaultAsync(x =>
                    x.MaBan == donHang.MaBan);

            if (ban != null)
            {
                ban.TrangThai = "Trống";
            }

            db.DonHangs.Remove(donHang);

            await db.SaveChangesAsync();

            MessageBox.Show(
                "Xóa đơn hàng thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadDonHang();
            LoadBan();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (maDon == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn đơn hàng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var frm =
                new FrmChiTietDonHang(maDon);

            frm.ShowDialog();

            LoadDonHang();
        }

        private void cboTrangThai_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            LoadDonHang();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();

            LoadBan();
            LoadNhanVien();
            LoadDonHang();
        }

        private void ClearForm()
        {
            maDon = 0;

            dgvDonHang.ClearSelection();
        }
    }
}