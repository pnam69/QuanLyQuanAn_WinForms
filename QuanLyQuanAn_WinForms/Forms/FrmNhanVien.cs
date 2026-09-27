using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Models;

namespace QuanLyQuanAn_WinForms.Forms
{
    public partial class FrmNhanVien : Form
    {
        private int maNV = 0;

        public FrmNhanVien()
        {
            InitializeComponent();
            LoadVaiTro();
            LoadTrangThai();
            LoadNhanVien();

            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
        }

        private void LoadVaiTro()
        {
            cboVaiTro.Items.Clear();

            cboVaiTro.Items.Add("Admin");
            cboVaiTro.Items.Add("Employee");

            cboVaiTro.SelectedIndex = 1;
        }

        private void LoadTrangThai()
        {
            cboTrangThai.Items.Clear();

            cboTrangThai.Items.Add("Hoạt động");
            cboTrangThai.Items.Add("Ngừng hoạt động");

            cboTrangThai.SelectedIndex = 0;
        }

        private async void LoadNhanVien()
        {
            using var db = DbContextFactory.Create();

            var danhSach = await db.NhanViens
                .AsNoTracking()
                .OrderBy(x => x.MaNV)
                .Select(x => new
                {
                    x.MaNV,
                    x.HoTen,
                    x.TaiKhoan,
                    x.VaiTro,
                    x.TrangThai
                })
                .ToListAsync();

            dgvNhanVien.DataSource = danhSach;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(taiKhoan) ||
                string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var db = DbContextFactory.Create();

            bool taiKhoanTonTai = await db.NhanViens
                .AnyAsync(x => x.TaiKhoan == taiKhoan);

            if (taiKhoanTonTai)
            {
                MessageBox.Show(
                    "Tài khoản đã tồn tại.",
                    "Không thể thêm",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var nhanVien = new NhanVien
            {
                HoTen = hoTen,
                TaiKhoan = taiKhoan,
                MatKhau = matKhau,
                VaiTro = cboVaiTro.Text,
                TrangThai = cboTrangThai.Text
            };

            db.NhanViens.Add(nhanVien);
            await db.SaveChangesAsync();

            MessageBox.Show(
                "Thêm nhân viên thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadNhanVien();
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (maNV == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên cần sửa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string taiKhoan = txtTaiKhoan.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(taiKhoan))
            {
                MessageBox.Show(
                    "Vui lòng nhập họ tên và tài khoản.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var db = DbContextFactory.Create();

            bool taiKhoanTrung = await db.NhanViens
                .AnyAsync(x =>
                    x.TaiKhoan == taiKhoan &&
                    x.MaNV != maNV);

            if (taiKhoanTrung)
            {
                MessageBox.Show(
                    "Tài khoản đã được sử dụng bởi nhân viên khác.",
                    "Không thể sửa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var nhanVien = await db.NhanViens
                .FirstOrDefaultAsync(x => x.MaNV == maNV);

            if (nhanVien == null)
            {
                return;
            }

            nhanVien.HoTen = hoTen;
            nhanVien.TaiKhoan = taiKhoan;
            nhanVien.VaiTro = cboVaiTro.Text;
            nhanVien.TrangThai = cboTrangThai.Text;

            // Chỉ đổi mật khẩu nếu người dùng nhập mật khẩu mới.
            if (!string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                nhanVien.MatKhau = txtMatKhau.Text;
            }

            await db.SaveChangesAsync();

            MessageBox.Show(
                "Cập nhật nhân viên thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadNhanVien();
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (maNV == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn nhân viên cần xóa.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (maNV == 1)
            {
                MessageBox.Show(
                    "Không thể xóa tài khoản quản trị chính.",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var result = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            using var db = DbContextFactory.Create();

            bool coDonHang = await db.DonHangs
                .AnyAsync(x => x.MaNV == maNV);

            if (coDonHang)
            {
                MessageBox.Show(
                    "Không thể xóa nhân viên vì nhân viên này đã có đơn hàng.",
                    "Không thể xóa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            var nhanVien = await db.NhanViens
                .FirstOrDefaultAsync(x => x.MaNV == maNV);

            if (nhanVien == null)
            {
                return;
            }

            db.NhanViens.Remove(nhanVien);
            await db.SaveChangesAsync();

            MessageBox.Show(
                "Xóa nhân viên thành công.",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();
            LoadNhanVien();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadNhanVien();
        }

        private void ClearForm()
        {
            maNV = 0;

            txtHoTen.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();

            cboVaiTro.SelectedIndex = 1;
            cboTrangThai.SelectedIndex = 0;

            dgvNhanVien.ClearSelection();
        }

        private async void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var row = dgvNhanVien.Rows[e.RowIndex];

            maNV = Convert.ToInt32(row.Cells["MaNV"].Value);

            txtHoTen.Text =
                row.Cells["HoTen"].Value?.ToString() ?? "";

            txtTaiKhoan.Text =
                row.Cells["TaiKhoan"].Value?.ToString() ?? "";

            cboVaiTro.Text =
                row.Cells["VaiTro"].Value?.ToString() ?? "";

            cboTrangThai.Text =
                row.Cells["TrangThai"].Value?.ToString() ?? "";

            txtMatKhau.Clear();
        }
    }
}
