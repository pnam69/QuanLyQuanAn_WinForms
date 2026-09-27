namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmChiTietDonHang
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
            cboMonAn = new ComboBox();
            lblTrangThai = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblMaDon = new Label();
            label1 = new Label();
            numSoLuong = new NumericUpDown();
            btnThanhToan = new Button();
            lblTongTien = new Label();
            btnDong = new Button();
            dgvChiTiet = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // cboMonAn
            // 
            cboMonAn.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonAn.FormattingEnabled = true;
            cboMonAn.Location = new Point(142, 78);
            cboMonAn.Name = "cboMonAn";
            cboMonAn.Size = new Size(194, 28);
            cboMonAn.TabIndex = 48;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(18, 81);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(59, 20);
            lblTrangThai.TabIndex = 47;
            lblTrangThai.Text = "Món ăn";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(242, 125);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 44;
            btnXoa.Text = "Xóa món";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(127, 125);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 43;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(18, 125);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 42;
            btnThem.Text = "Thêm món";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lblMaDon
            // 
            lblMaDon.AutoSize = true;
            lblMaDon.Location = new Point(-286, 366);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Size = new Size(63, 20);
            lblMaDon.TabIndex = 40;
            lblMaDon.Text = "Mã đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 51;
            label1.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(132, 25);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 52;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(373, 490);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 53;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(127, 494);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(75, 20);
            lblTongTien.TabIndex = 54;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // btnDong
            // 
            btnDong.Location = new Point(535, 490);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 55;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(12, 169);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(778, 298);
            dgvChiTiet.TabIndex = 56;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            // 
            // FrmChiTietDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 532);
            Controls.Add(dgvChiTiet);
            Controls.Add(btnDong);
            Controls.Add(lblTongTien);
            Controls.Add(btnThanhToan);
            Controls.Add(numSoLuong);
            Controls.Add(label1);
            Controls.Add(cboMonAn);
            Controls.Add(lblTrangThai);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblMaDon);
            Name = "FrmChiTietDonHang";
            Text = "FrmChiTietDonHang";
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboTrangThai;
        private Label label3;
        private ComboBox cboMonAn;
        private Label lblTrangThai;
        private DataGridView dgvChiTiet;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboNhanVien;
        private Label lblMaDon;
        private Label label1;
        private NumericUpDown numSoLuong;
        private Button btnThanhToan;
        private Label lblTongTien;
        private Button btnDong;
    }
}