namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmNhanVien
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
            lblTrangThai = new Label();
            dgvNhanVien = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboTrangThai = new ComboBox();
            txtHoTen = new TextBox();
            lblTenDM = new Label();
            label1 = new Label();
            cboVaiTro = new ComboBox();
            txtMatKhau = new TextBox();
            label2 = new Label();
            txtTaiKhoan = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(413, 90);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(75, 20);
            lblTrangThai.TabIndex = 17;
            lblTrangThai.Text = "Trạng thái";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(12, 237);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(618, 201);
            dgvNhanVien.TabIndex = 16;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(354, 188);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(243, 188);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(128, 188);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(19, 188);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(514, 87);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(194, 28);
            cboTrangThai.TabIndex = 11;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(170, 21);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(194, 27);
            txtHoTen.TabIndex = 10;
            // 
            // lblTenDM
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Location = new Point(12, 24);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(57, 20);
            lblTenDM.TabIndex = 9;
            lblTenDM.Text = "Họ tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(413, 24);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 19;
            label1.Text = "Vai trò";
            // 
            // cboVaiTro
            // 
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(514, 21);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(194, 28);
            cboVaiTro.TabIndex = 18;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(170, 136);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(194, 27);
            txtMatKhau.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 20;
            label2.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(170, 80);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(194, 27);
            txtTaiKhoan.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 22;
            label3.Text = "Tài khoản:";
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 450);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label3);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboVaiTro);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboTrangThai);
            Controls.Add(txtHoTen);
            Controls.Add(lblTenDM);
            Name = "FrmNhanVien";
            Text = "FrmNhanVien";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrangThai;
        private DataGridView dgvNhanVien;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboTrangThai;
        private TextBox txtHoTen;
        private Label lblTenDM;
        private Label label1;
        private ComboBox cboVaiTro;
        private TextBox txtMatKhau;
        private Label label2;
        private TextBox txtTaiKhoan;
        private Label label3;
    }
}