using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            lblXinChao = new Label();
            lblVaiTro = new Label();
            btnDangXuat = new Button();
            btnThongKe = new Button();
            btnNhanVien = new Button();
            btnDanhMuc = new Button();
            btnBan = new Button();
            btnMonAn = new Button();
            btnDonHang = new Button();
            lblNhanVien = new Label();
            btnTrangChu = new Button();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMenu.BackColor = Color.FromArgb(241, 245, 249);
            pnlMenu.Controls.Add(lblXinChao);
            pnlMenu.Controls.Add(lblVaiTro);
            pnlMenu.Controls.Add(btnDangXuat);
            pnlMenu.Controls.Add(btnThongKe);
            pnlMenu.Controls.Add(btnNhanVien);
            pnlMenu.Controls.Add(btnDanhMuc);
            pnlMenu.Controls.Add(btnBan);
            pnlMenu.Controls.Add(btnMonAn);
            pnlMenu.Controls.Add(btnDonHang);
            pnlMenu.Controls.Add(lblNhanVien);
            pnlMenu.Controls.Add(btnTrangChu);
            pnlMenu.Location = new Point(12, 12);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(956, 556);
            pnlMenu.TabIndex = 0;
            // 
            // lblNhanVien (Hiển thị tên nhân viên đăng nhập)
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.ForeColor = Color.FromArgb(30, 41, 59);
            lblNhanVien.Location = new Point(24, 30);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(96, 25);
            lblNhanVien.TabIndex = 1;
            lblNhanVien.Text = "Nhân viên";
            // 
            // lblVaiTro (Hiển thị vai trò / chức vụ)
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVaiTro.ForeColor = Color.FromArgb(37, 99, 235);
            lblVaiTro.Location = new Point(24, 86);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(61, 23);
            lblVaiTro.TabIndex = 10;
            lblVaiTro.Text = "Vai trò";
            // 
            // btnTrangChu (Hàng 1 - Cột 1)
            // 
            btnTrangChu.BackColor = Color.FromArgb(51, 65, 85);
            btnTrangChu.Cursor = Cursors.Hand;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrangChu.ForeColor = Color.White;
            btnTrangChu.Location = new Point(290, 22);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(150, 44);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "🏠 Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnBan (Hàng 1 - Cột 2)
            // 
            btnBan.BackColor = Color.FromArgb(16, 185, 129);
            btnBan.Cursor = Cursors.Hand;
            btnBan.FlatAppearance.BorderSize = 0;
            btnBan.FlatStyle = FlatStyle.Flat;
            btnBan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBan.ForeColor = Color.White;
            btnBan.Location = new Point(454, 22);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(150, 44);
            btnBan.TabIndex = 4;
            btnBan.Text = "🪑 Sơ đồ bàn";
            btnBan.UseVisualStyleBackColor = false;
            btnBan.Click += btnBan_Click;
            // 
            // btnDonHang (Hàng 1 - Cột 3)
            // 
            btnDonHang.BackColor = Color.FromArgb(37, 99, 235);
            btnDonHang.Cursor = Cursors.Hand;
            btnDonHang.FlatAppearance.BorderSize = 0;
            btnDonHang.FlatStyle = FlatStyle.Flat;
            btnDonHang.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonHang.ForeColor = Color.White;
            btnDonHang.Location = new Point(618, 22);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(150, 44);
            btnDonHang.TabIndex = 2;
            btnDonHang.Text = "🧾 Đơn hàng";
            btnDonHang.UseVisualStyleBackColor = false;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // btnMonAn (Hàng 1 - Cột 4)
            // 
            btnMonAn.BackColor = Color.FromArgb(245, 158, 11);
            btnMonAn.Cursor = Cursors.Hand;
            btnMonAn.FlatAppearance.BorderSize = 0;
            btnMonAn.FlatStyle = FlatStyle.Flat;
            btnMonAn.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonAn.ForeColor = Color.White;
            btnMonAn.Location = new Point(782, 22);
            btnMonAn.Name = "btnMonAn";
            btnMonAn.Size = new Size(150, 44);
            btnMonAn.TabIndex = 3;
            btnMonAn.Text = "🍜 Món ăn";
            btnMonAn.UseVisualStyleBackColor = false;
            btnMonAn.Click += btnMonAn_Click;
            // 
            // btnDanhMuc (Hàng 2 - Cột 1)
            // 
            btnDanhMuc.BackColor = Color.FromArgb(13, 148, 136);
            btnDanhMuc.Cursor = Cursors.Hand;
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDanhMuc.ForeColor = Color.White;
            btnDanhMuc.Location = new Point(290, 78);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(150, 44);
            btnDanhMuc.TabIndex = 5;
            btnDanhMuc.Text = "📂 Danh mục";
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnNhanVien (Hàng 2 - Cột 2)
            // 
            btnNhanVien.BackColor = Color.FromArgb(79, 70, 229);
            btnNhanVien.Cursor = Cursors.Hand;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Location = new Point(454, 78);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(150, 44);
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "👥 Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnThongKe (Hàng 2 - Cột 3)
            // 
            btnThongKe.BackColor = Color.FromArgb(147, 51, 234);
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(618, 78);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(150, 44);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "📊 Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnDangXuat (Hàng 2 - Cột 4)
            // 
            btnDangXuat.BackColor = Color.FromArgb(225, 29, 72);
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(782, 78);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(150, 44);
            btnDangXuat.TabIndex = 9;
            btnDangXuat.Text = "🚪 Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // lblXinChao (Khung màn hình chào mừng trung tâm)
            // 
            lblXinChao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblXinChao.AutoSize = false;
            lblXinChao.BackColor = Color.White;
            lblXinChao.BorderStyle = BorderStyle.FixedSingle;
            lblXinChao.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXinChao.ForeColor = Color.FromArgb(30, 41, 59);
            lblXinChao.Location = new Point(24, 146);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(908, 386);
            lblXinChao.TabIndex = 11;
            lblXinChao.Text = "👋 Chào mừng đến với Hệ thống Quản lý Quán ăn";
            lblXinChao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 41, 59);
            ClientSize = new Size(980, 580);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(960, 540);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Quán ăn - Trang chủ";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnDangXuat;
        private Button btnThongKe;
        private Button btnNhanVien;
        private Button btnDanhMuc;
        private Button btnBan;
        private Button btnMonAn;
        private Button btnDonHang;
        private Label lblNhanVien;
        private Button btnTrangChu;
        private Label lblVaiTro;
        private Label lblXinChao;
    }
}