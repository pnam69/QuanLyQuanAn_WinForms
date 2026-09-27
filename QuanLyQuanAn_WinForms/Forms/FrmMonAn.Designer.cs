namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmMonAn
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
            dgvMonAn = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboDanhMuc = new ComboBox();
            txtTenMon = new TextBox();
            lblTenDM = new Label();
            numDonGia = new NumericUpDown();
            label1 = new Label();
            cboTrangThai = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            SuspendLayout();
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(12, 69);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(62, 20);
            lblTrangThai.TabIndex = 17;
            lblTrangThai.Text = "Đơn giá";
            // 
            // dgvMonAn
            // 
            dgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonAn.Location = new Point(12, 250);
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.RowHeadersWidth = 51;
            dgvMonAn.Size = new Size(618, 201);
            dgvMonAn.TabIndex = 16;
            dgvMonAn.CellClick += dgvMonAn_CellClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(347, 206);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(236, 206);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(121, 206);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 206);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(170, 112);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(194, 28);
            cboDanhMuc.TabIndex = 11;
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(170, 18);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(194, 27);
            txtTenMon.TabIndex = 10;
            // 
            // lblTenDM
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Location = new Point(12, 21);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(66, 20);
            lblTenDM.TabIndex = 9;
            lblTenDM.Text = "Tên món";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(170, 67);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(150, 27);
            numDonGia.TabIndex = 18;
            numDonGia.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 159);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 20;
            label1.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(170, 151);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(194, 28);
            cboTrangThai.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 22;
            label3.Text = "Danh mục";
            // 
            // FrmMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 463);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cboTrangThai);
            Controls.Add(numDonGia);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvMonAn);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboDanhMuc);
            Controls.Add(txtTenMon);
            Controls.Add(lblTenDM);
            Name = "FrmMonAn";
            Text = "FrmMonAn";
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrangThai;
        private DataGridView dgvMonAn;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboDanhMuc;
        private TextBox txtTenMon;
        private Label lblTenDM;
        private NumericUpDown numDonGia;
        private Label label1;
        private ComboBox cboTrangThai;
        private Label label3;
    }
}