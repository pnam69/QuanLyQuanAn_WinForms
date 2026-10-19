using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            chkHienMatKhau = new CheckBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // label1 (Nhãn Tài khoản)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 41, 59);
            label1.Location = new Point(55, 38);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 0;
            label1.Text = "👤 Tài khoản:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = Color.White;
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.ForeColor = Color.FromArgb(15, 23, 42);
            txtTaiKhoan.Location = new Point(55, 68);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(330, 33);
            txtTaiKhoan.TabIndex = 2;
            // 
            // label2 (Nhãn Mật khẩu)
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(30, 41, 59);
            label2.Location = new Point(55, 122);
            label2.Name = "label2";
            label2.Size = new Size(107, 24);
            label2.TabIndex = 1;
            label2.Text = "🔒 Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.FromArgb(15, 23, 42);
            txtMatKhau.Location = new Point(55, 152);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(330, 33);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Cursor = Cursors.Hand;
            chkHienMatKhau.Font = new Font("Segoe UI", 9.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHienMatKhau.ForeColor = Color.FromArgb(71, 85, 105);
            chkHienMatKhau.Location = new Point(55, 198);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(134, 26);
            chkHienMatKhau.TabIndex = 4;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(37, 99, 235);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(55, 244);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(330, 46);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "🔐 ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(100, 116, 139);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(55, 304);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(330, 42);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "✖ Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FrmLogin
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            CancelButton = btnThoat;
            ClientSize = new Size(440, 390);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(chkHienMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống - Quản lý quán ăn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private CheckBox chkHienMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}