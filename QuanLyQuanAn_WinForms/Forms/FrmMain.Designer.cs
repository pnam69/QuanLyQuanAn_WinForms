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
            pnlMenu.Size = new Size(776, 426);
            pnlMenu.TabIndex = 0;
            // 
            // lblXinChao
            // 
            lblXinChao.AutoSize = true;
            lblXinChao.Location = new Point(265, 203);
            lblXinChao.Name = "lblXinChao";
            lblXinChao.Size = new Size(75, 20);
            lblXinChao.TabIndex = 11;
            lblXinChao.Text = "Nhân viên";
            // 
            // lblVaiTro
            // 
            lblVaiTro.AutoSize = true;
            lblVaiTro.Location = new Point(21, 109);
            lblVaiTro.Name = "lblVaiTro";
            lblVaiTro.Size = new Size(52, 20);
            lblVaiTro.TabIndex = 10;
            lblVaiTro.Text = "Vai trò";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(574, 103);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(88, 33);
            btnDangXuat.TabIndex = 9;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(442, 103);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(88, 33);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Location = new Point(310, 103);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(88, 33);
            btnNhanVien.TabIndex = 6;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Location = new Point(574, 41);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(88, 33);
            btnDanhMuc.TabIndex = 5;
            btnDanhMuc.Text = "Danh mục";
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnBan
            // 
            btnBan.Location = new Point(192, 103);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(88, 33);
            btnBan.TabIndex = 4;
            btnBan.Text = "Bàn";
            btnBan.UseVisualStyleBackColor = true;
            btnBan.Click += btnBan_Click;
            // 
            // btnMonAn
            // 
            btnMonAn.Location = new Point(442, 41);
            btnMonAn.Name = "btnMonAn";
            btnMonAn.Size = new Size(88, 33);
            btnMonAn.TabIndex = 3;
            btnMonAn.Text = "Món ăn";
            btnMonAn.UseVisualStyleBackColor = true;
            btnMonAn.Click += btnMonAn_Click;
            // 
            // btnDonHang
            // 
            btnDonHang.Location = new Point(310, 41);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(88, 33);
            btnDonHang.TabIndex = 2;
            btnDonHang.Text = "Đơn hàng";
            btnDonHang.UseVisualStyleBackColor = true;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(21, 47);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(75, 20);
            lblNhanVien.TabIndex = 1;
            lblNhanVien.Text = "Nhân viên";
            // 
            // btnTrangChu
            // 
            btnTrangChu.Location = new Point(192, 41);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(88, 33);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMenu);
            Name = "FrmMain";
            Text = "FrmMain";
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