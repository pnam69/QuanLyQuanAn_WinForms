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
        // Biến lưu trữ form con đang được hiển thị trong Panel
        private Form currentChildForm;

        public FrmMain()
        {
            InitializeComponent();

            lblNhanVien.Text = CurrentUser.HoTen;
            lblVaiTro.Text = CurrentUser.VaiTro;
            LoadThongTinNguoiDung();
            PhanQuyen();

            this.WindowState = FormWindowState.Maximized;

            // Ban đầu, ẩn khung nhúng form để hiện lời chào (lblXinChao)
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

        // Hàm xử lý cốt lõi: Nhúng form mới vào khung và đẩy form cũ ra thành popup
        private void OpenChildForm(Form childForm)
        {
            // 1. Kiểm tra nếu form này đang mở lơ lửng bên ngoài (dạng popup) thì gọi nó lên trên cùng
            Form existingForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.GetType() == childForm.GetType() && f != this);
            if (existingForm != null)
            {
                existingForm.BringToFront();
                return; // Không nhúng lại nữa
            }

            // 2. Nếu trong Panel đang có một Form khác, đẩy nó ra ngoài thành popup
            if (currentChildForm != null)
            {
                pnlContent.Controls.Remove(currentChildForm);
                currentChildForm.Parent = null; 
                currentChildForm.TopLevel = true;
                currentChildForm.FormBorderStyle = FormBorderStyle.Sizable;
                currentChildForm.Dock = DockStyle.None;
                currentChildForm.StartPosition = FormStartPosition.CenterScreen;

                currentChildForm.Show();
            }

            // 3. Đưa Form mới vào trong Panel
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();

            // Ẩn chữ Xin chào, hiện Panel chứa Form
            lblXinChao.Visible = false;
            pnlContent.Visible = true;

            childForm.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            // Đóng tất cả các form chức năng đang mở
            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                if (frm != this && frm.Name != "FrmLogin")
                {
                    frm.Close();
                }
            }

            // Khôi phục màn hình chính
            currentChildForm = null;
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