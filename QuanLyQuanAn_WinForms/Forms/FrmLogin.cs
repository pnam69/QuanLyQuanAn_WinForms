using Microsoft.EntityFrameworkCore;
using QuanLyQuanAn_WinForms.Data;
using QuanLyQuanAn_WinForms.Helpers;


namespace QuanLyQuanAn_WinForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(taiKhoan) ||
                string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show(
                    "Vui lòng nhập tài khoản và mật khẩu.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using var db = DbContextFactory.Create();

            var nhanVien = await db.NhanViens
                .FirstOrDefaultAsync(x =>
                    x.TaiKhoan == taiKhoan &&
                    x.MatKhau == matKhau);

            if (nhanVien == null)
            {
                MessageBox.Show(
                    "Tài khoản hoặc mật khẩu không đúng.",
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (nhanVien.TrangThai != "Hoạt động")
            {
                MessageBox.Show(
                    "Tài khoản đã ngừng hoạt động.",
                    "Không thể đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            CurrentUser.MaNV = nhanVien.MaNV;
            CurrentUser.HoTen = nhanVien.HoTen;
            CurrentUser.TaiKhoan = nhanVien.TaiKhoan;
            CurrentUser.VaiTro = nhanVien.VaiTro;

            Hide();

            using (var frmMain = new FrmMain())
            {
                frmMain.ShowDialog();
            }

            Show();
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
