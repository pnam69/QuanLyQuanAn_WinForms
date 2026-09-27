namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmDonHang
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
            label3 = new Label();
            cboBan = new ComboBox();
            lblTrangThai = new Label();
            dgvDonHang = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboNhanVien = new ComboBox();
            lblTenDM = new Label();
            cboTrangThai = new ComboBox();
            btnChiTiet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 79);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 37;
            label3.Text = "Nhân viên";
            // 
            // cboBan
            // 
            cboBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBan.FormattingEnabled = true;
            cboBan.Location = new Point(210, 17);
            cboBan.Name = "cboBan";
            cboBan.Size = new Size(194, 28);
            cboBan.TabIndex = 33;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(52, 138);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(75, 20);
            lblTrangThai.TabIndex = 32;
            lblTrangThai.Text = "Trạng thái";
            // 
            // dgvDonHang
            // 
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Location = new Point(12, 233);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.Size = new Size(861, 247);
            dgvDonHang.TabIndex = 31;
            dgvDonHang.CellClick += dgvDonHang_CellClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(394, 184);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 30;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(283, 184);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 29;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(168, 184);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 28;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(59, 184);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 27;
            btnThem.Text = "Tạo đơn";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(210, 76);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(194, 28);
            cboNhanVien.TabIndex = 26;
            // 
            // lblTenDM
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Location = new Point(52, 20);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(34, 20);
            lblTenDM.TabIndex = 24;
            lblTenDM.Text = "Bàn";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(210, 135);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(194, 28);
            cboTrangThai.TabIndex = 39;
            // 
            // btnChiTiet
            // 
            btnChiTiet.Location = new Point(515, 184);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(94, 29);
            btnChiTiet.TabIndex = 40;
            btnChiTiet.Text = "Chi tiết";
            btnChiTiet.UseVisualStyleBackColor = true;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // FrmDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 492);
            Controls.Add(btnChiTiet);
            Controls.Add(cboTrangThai);
            Controls.Add(label3);
            Controls.Add(cboBan);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvDonHang);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboNhanVien);
            Controls.Add(lblTenDM);
            Name = "FrmDonHang";
            Text = "FrmDonHang";
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cboBan;
        private Label lblTrangThai;
        private DataGridView dgvDonHang;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboNhanVien;
        private Label lblTenDM;
        private ComboBox cboTrangThai;
        private Button btnChiTiet;
    }
}