using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanAn_WinForms.Forms;
using QuanLyQuanAn_WinForms.Helpers;

namespace QuanLyQuanAn_WinForms
{
    public partial class FrmMain : Form
    {
        private Form? currentChildForm;

        public FrmMain()
        {
            InitializeComponent();

            lblNhanVien.Text = CurrentUser.HoTen;
            lblVaiTro.Text = CurrentUser.VaiTro;
            LoadThongTinNguoiDung();
            PhanQuyen();

            this.WindowState = FormWindowState.Maximized;

            pnlContent.Visible = false;
        }

        private void LoadThongTinNguoiDung()
        {
            lblXinChao.Text = $"Xin chào, {CurrentUser.HoTen} ({CurrentUser.VaiTro})";
        }

        private void PhanQuyen()
        {
            bool isAdmin = CurrentUser.IsAdmin;

            btnNhanVien.Visible = isAdmin;
            btnDanhMuc.Visible = isAdmin;
            btnThongKe.Visible = isAdmin;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm.Dispose();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);

            lblXinChao.Visible = false;
            pnlContent.Visible = true;

            childForm.Show();
        }


        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm.Dispose();
                currentChildForm = null;
            }

            pnlContent.Controls.Clear();
            pnlContent.Visible = false;
            lblXinChao.Visible = true;
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDonHang());
        }

        private void btnMonAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMonAn());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhMuc());
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBan());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            CurrentUser.Clear();
            this.Close();
        }
    }
}