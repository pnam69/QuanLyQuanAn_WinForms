using QuanLyQuanAn_WinForms.Forms;
using QuanLyQuanAn_WinForms.Helpers;

namespace QuanLyQuanAn_WinForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            lblNhanVien.Text = CurrentUser.HoTen;
            lblVaiTro.Text = CurrentUser.VaiTro;
            LoadThongTinNguoiDung();
            PhanQuyen();

        }

        private void LoadThongTinNguoiDung()
        {
            lblXinChao.Text =
                $"Xin chào, {CurrentUser.HoTen} ({CurrentUser.VaiTro})";
        }

        private void PhanQuyen()
        {
            bool isAdmin = CurrentUser.IsAdmin;

            btnNhanVien.Visible = isAdmin;
            btnDanhMuc.Visible = isAdmin;
            btnThongKe.Visible = isAdmin;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            using var frm = new FrmDonHang();
            frm.ShowDialog();
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            using var frm = new FrmMonAn();
            frm.ShowDialog();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using var frm = new FrmDanhMuc();
            frm.ShowDialog();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            using var frm = new FrmBan();
            frm.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            using var frm = new FrmNhanVien();
            frm.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            CurrentUser.Clear();
            Close();
        }
    }
}
