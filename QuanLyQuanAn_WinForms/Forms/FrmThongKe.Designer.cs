namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSoDon;
        private System.Windows.Forms.Label lblTrungBinh;
        private System.Windows.Forms.Label lblDonDangPhucVu;

        private System.Windows.Forms.DataGridView dgvMonBanChay;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridView dgvTrangThai;

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
            lblDoanhThu = new Label();
            btnHomNay = new Button();
            btnThangNay = new Button();
            btnNamNay = new Button();
            btnThongKe = new Button();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            lblSoDon = new Label();
            lblDonDangPhucVu = new Label();
            lblTrungBinh = new Label();
            dgvDoanhThu = new DataGridView();
            dgvMonBanChay = new DataGridView();
            dgvNhanVien = new DataGridView();
            dgvTrangThai = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnXuatExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonBanChay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrangThai).BeginInit();
            SuspendLayout();
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Location = new Point(103, 147);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(26, 20);
            lblDoanhThu.TabIndex = 1;
            lblDoanhThu.Text = "0đ";
            // 
            // btnHomNay
            // 
            btnHomNay.Location = new Point(12, 79);
            btnHomNay.Name = "btnHomNay";
            btnHomNay.Size = new Size(94, 29);
            btnHomNay.TabIndex = 2;
            btnHomNay.Text = "Hôm nay";
            btnHomNay.UseVisualStyleBackColor = true;
            btnHomNay.Click += btnHomNay_Click;
            // 
            // btnThangNay
            // 
            btnThangNay.Location = new Point(149, 79);
            btnThangNay.Name = "btnThangNay";
            btnThangNay.Size = new Size(94, 29);
            btnThangNay.TabIndex = 3;
            btnThangNay.Text = "Tháng này";
            btnThangNay.UseVisualStyleBackColor = true;
            btnThangNay.Click += btnThangNay_Click;
            // 
            // btnNamNay
            // 
            btnNamNay.Location = new Point(291, 79);
            btnNamNay.Name = "btnNamNay";
            btnNamNay.Size = new Size(94, 29);
            btnNamNay.TabIndex = 4;
            btnNamNay.Text = "Năm nay";
            btnNamNay.UseVisualStyleBackColor = true;
            btnNamNay.Click += btnNamNay_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(446, 79);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(94, 29);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(103, 28);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 27);
            dtpTuNgay.TabIndex = 6;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(490, 26);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 27);
            dtpDenNgay.TabIndex = 7;
            // 
            // lblSoDon
            // 
            lblSoDon.AutoSize = true;
            lblSoDon.Location = new Point(490, 147);
            lblSoDon.Name = "lblSoDon";
            lblSoDon.Size = new Size(17, 20);
            lblSoDon.TabIndex = 8;
            lblSoDon.Text = "0";
            // 
            // lblDonDangPhucVu
            // 
            lblDonDangPhucVu.AutoSize = true;
            lblDonDangPhucVu.Location = new Point(559, 241);
            lblDonDangPhucVu.Name = "lblDonDangPhucVu";
            lblDonDangPhucVu.Size = new Size(17, 20);
            lblDonDangPhucVu.TabIndex = 9;
            lblDonDangPhucVu.Text = "0";
            // 
            // lblTrungBinh
            // 
            lblTrungBinh.AutoSize = true;
            lblTrungBinh.Location = new Point(178, 241);
            lblTrungBinh.Name = "lblTrungBinh";
            lblTrungBinh.Size = new Size(26, 20);
            lblTrungBinh.TabIndex = 10;
            lblTrungBinh.Text = "0đ";
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(12, 285);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoanhThu.Size = new Size(341, 200);
            dgvDoanhThu.TabIndex = 11;
            // 
            // dgvMonBanChay
            // 
            dgvMonBanChay.AllowUserToAddRows = false;
            dgvMonBanChay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonBanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonBanChay.Location = new Point(407, 285);
            dgvMonBanChay.Name = "dgvMonBanChay";
            dgvMonBanChay.ReadOnly = true;
            dgvMonBanChay.RowHeadersWidth = 51;
            dgvMonBanChay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonBanChay.Size = new Size(365, 200);
            dgvMonBanChay.TabIndex = 12;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(12, 522);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(341, 216);
            dgvNhanVien.TabIndex = 13;
            // 
            // dgvTrangThai
            // 
            dgvTrangThai.AllowUserToAddRows = false;
            dgvTrangThai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrangThai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrangThai.Location = new Point(407, 522);
            dgvTrangThai.Name = "dgvTrangThai";
            dgvTrangThai.ReadOnly = true;
            dgvTrangThai.RowHeadersWidth = 51;
            dgvTrangThai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrangThai.Size = new Size(365, 216);
            dgvTrangThai.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 15;
            label1.Text = "Từ ngày:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 31);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 16;
            label2.Text = "Đến ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 17;
            label3.Text = "Doanh thu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 147);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 18;
            label4.Text = "Số đơn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 241);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 19;
            label5.Text = "Đơn đang phục vụ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 241);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 20;
            label6.Text = "Doanh thu trung bình:";
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(604, 79);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(94, 29);
            btnXuatExcel.TabIndex = 21;
            btnXuatExcel.Text = "Xuất excel";
            btnXuatExcel.UseVisualStyleBackColor = true;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 762);
            Controls.Add(btnXuatExcel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTrangThai);
            Controls.Add(dgvNhanVien);
            Controls.Add(dgvMonBanChay);
            Controls.Add(dgvDoanhThu);
            Controls.Add(lblTrungBinh);
            Controls.Add(lblDonDangPhucVu);
            Controls.Add(lblSoDon);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnThongKe);
            Controls.Add(btnNamNay);
            Controls.Add(btnThangNay);
            Controls.Add(btnHomNay);
            Controls.Add(lblDoanhThu);
            Name = "FrmThongKe";
            Text = "FrmThongKe";
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMonBanChay).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTrangThai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDoanhThu;
        private Button btnHomNay;
        private Button btnThangNay;
        private Button btnNamNay;
        private Button btnThongKe;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private DataGridView dgvDoanhThu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnXuatExcel;
    }
}