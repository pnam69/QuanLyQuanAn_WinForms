using System.Drawing;
using System.Windows.Forms;

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
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle alternatingRowStyle = new DataGridViewCellStyle();

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
            // label1 (Nhãn Từ ngày)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 65, 85);
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 15;
            label1.Text = "Từ ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(106, 24);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(160, 30);
            dtpTuNgay.TabIndex = 6;
            // 
            // label2 (Nhãn Đến ngày)
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Location = new Point(290, 28);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 16;
            label2.Text = "Đến ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(382, 24);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(160, 30);
            dtpDenNgay.TabIndex = 7;
            // 
            // btnHomNay
            // 
            btnHomNay.BackColor = Color.FromArgb(100, 116, 139);
            btnHomNay.Cursor = Cursors.Hand;
            btnHomNay.FlatAppearance.BorderSize = 0;
            btnHomNay.FlatStyle = FlatStyle.Flat;
            btnHomNay.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHomNay.ForeColor = Color.White;
            btnHomNay.Location = new Point(24, 72);
            btnHomNay.Name = "btnHomNay";
            btnHomNay.Size = new Size(100, 34);
            btnHomNay.TabIndex = 2;
            btnHomNay.Text = "Hôm nay";
            btnHomNay.UseVisualStyleBackColor = false;
            btnHomNay.Click += btnHomNay_Click;
            // 
            // btnThangNay
            // 
            btnThangNay.BackColor = Color.FromArgb(100, 116, 139);
            btnThangNay.Cursor = Cursors.Hand;
            btnThangNay.FlatAppearance.BorderSize = 0;
            btnThangNay.FlatStyle = FlatStyle.Flat;
            btnThangNay.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThangNay.ForeColor = Color.White;
            btnThangNay.Location = new Point(136, 72);
            btnThangNay.Name = "btnThangNay";
            btnThangNay.Size = new Size(100, 34);
            btnThangNay.TabIndex = 3;
            btnThangNay.Text = "Tháng này";
            btnThangNay.UseVisualStyleBackColor = false;
            btnThangNay.Click += btnThangNay_Click;
            // 
            // btnNamNay
            // 
            btnNamNay.BackColor = Color.FromArgb(100, 116, 139);
            btnNamNay.Cursor = Cursors.Hand;
            btnNamNay.FlatAppearance.BorderSize = 0;
            btnNamNay.FlatStyle = FlatStyle.Flat;
            btnNamNay.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNamNay.ForeColor = Color.White;
            btnNamNay.Location = new Point(248, 72);
            btnNamNay.Name = "btnNamNay";
            btnNamNay.Size = new Size(100, 34);
            btnNamNay.TabIndex = 4;
            btnNamNay.Text = "Năm nay";
            btnNamNay.UseVisualStyleBackColor = false;
            btnNamNay.Click += btnNamNay_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThongKe.BackColor = Color.FromArgb(37, 99, 235);
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(810, 24);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(130, 42);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "📊 Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.FromArgb(16, 185, 129);
            btnXuatExcel.Cursor = Cursors.Hand;
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(950, 24);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(130, 42);
            btnXuatExcel.TabIndex = 21;
            btnXuatExcel.Text = "📗 Xuất Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // label3 (Nhãn Tổng Doanh thu)
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(100, 116, 139);
            label3.Location = new Point(24, 130);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 17;
            label3.Text = "Tổng doanh thu";
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoanhThu.ForeColor = Color.FromArgb(220, 38, 38);
            lblDoanhThu.Location = new Point(20, 155);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(62, 37);
            lblDoanhThu.TabIndex = 1;
            lblDoanhThu.Text = "0 đ";
            // 
            // label6 (Nhãn DT Trung bình)
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(100, 116, 139);
            label6.Location = new Point(280, 130);
            label6.Name = "label6";
            label6.Size = new Size(174, 23);
            label6.TabIndex = 20;
            label6.Text = "Doanh thu trung bình";
            // 
            // lblTrungBinh
            // 
            lblTrungBinh.AutoSize = true;
            lblTrungBinh.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrungBinh.ForeColor = Color.FromArgb(245, 158, 11);
            lblTrungBinh.Location = new Point(276, 155);
            lblTrungBinh.Name = "lblTrungBinh";
            lblTrungBinh.Size = new Size(62, 37);
            lblTrungBinh.TabIndex = 10;
            lblTrungBinh.Text = "0 đ";
            // 
            // label4 (Nhãn Số đơn)
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(100, 116, 139);
            label4.Location = new Point(540, 130);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 18;
            label4.Text = "Tổng số đơn / Bill";
            // 
            // lblSoDon
            // 
            lblSoDon.AutoSize = true;
            lblSoDon.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoDon.ForeColor = Color.FromArgb(37, 99, 235);
            lblSoDon.Location = new Point(536, 155);
            lblSoDon.Name = "lblSoDon";
            lblSoDon.Size = new Size(33, 37);
            lblSoDon.TabIndex = 8;
            lblSoDon.Text = "0";
            // 
            // label5 (Nhãn Đơn đang phục vụ)
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(100, 116, 139);
            label5.Location = new Point(810, 130);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 19;
            label5.Text = "Đơn đang phục vụ";
            // 
            // lblDonDangPhucVu
            // 
            lblDonDangPhucVu.AutoSize = true;
            lblDonDangPhucVu.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonDangPhucVu.ForeColor = Color.FromArgb(16, 185, 129);
            lblDonDangPhucVu.Location = new Point(806, 155);
            lblDonDangPhucVu.Name = "lblDonDangPhucVu";
            lblDonDangPhucVu.Size = new Size(33, 37);
            lblDonDangPhucVu.TabIndex = 9;
            lblDonDangPhucVu.Text = "0";
            // 
            // Thiết lập Style chuẩn cho 4 lưới DataGridView
            //
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnHeaderStyle.BackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Padding = new Padding(4);
            columnHeaderStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.SelectionForeColor = Color.White;

            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            defaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            defaultCellStyle.Padding = new Padding(4, 2, 4, 2);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);

            alternatingRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            // 
            // dgvDoanhThu (Lưới 1 - Top Left)
            // 
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.BackgroundColor = Color.White;
            dgvDoanhThu.BorderStyle = BorderStyle.FixedSingle;
            dgvDoanhThu.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDoanhThu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDoanhThu.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvDoanhThu.ColumnHeadersHeight = 36;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDoanhThu.DefaultCellStyle = defaultCellStyle;
            dgvDoanhThu.AlternatingRowsDefaultCellStyle = alternatingRowStyle;
            dgvDoanhThu.EnableHeadersVisualStyles = false;
            dgvDoanhThu.GridColor = Color.FromArgb(226, 232, 240);
            dgvDoanhThu.Location = new Point(24, 215);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.RowHeadersVisible = false;
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.RowTemplate.Height = 32;
            dgvDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoanhThu.Size = new Size(516, 250);
            dgvDoanhThu.TabIndex = 11;
            // 
            // dgvMonBanChay (Lưới 2 - Top Right)
            // 
            dgvMonBanChay.AllowUserToAddRows = false;
            dgvMonBanChay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvMonBanChay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonBanChay.BackgroundColor = Color.White;
            dgvMonBanChay.BorderStyle = BorderStyle.FixedSingle;
            dgvMonBanChay.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMonBanChay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMonBanChay.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvMonBanChay.ColumnHeadersHeight = 36;
            dgvMonBanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMonBanChay.DefaultCellStyle = defaultCellStyle;
            dgvMonBanChay.AlternatingRowsDefaultCellStyle = alternatingRowStyle;
            dgvMonBanChay.EnableHeadersVisualStyles = false;
            dgvMonBanChay.GridColor = Color.FromArgb(226, 232, 240);
            dgvMonBanChay.Location = new Point(564, 215);
            dgvMonBanChay.Name = "dgvMonBanChay";
            dgvMonBanChay.ReadOnly = true;
            dgvMonBanChay.RowHeadersVisible = false;
            dgvMonBanChay.RowHeadersWidth = 51;
            dgvMonBanChay.RowTemplate.Height = 32;
            dgvMonBanChay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonBanChay.Size = new Size(516, 250);
            dgvMonBanChay.TabIndex = 12;
            // 
            // dgvNhanVien (Lưới 3 - Bottom Left)
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.FixedSingle;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvNhanVien.ColumnHeadersHeight = 36;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvNhanVien.DefaultCellStyle = defaultCellStyle;
            dgvNhanVien.AlternatingRowsDefaultCellStyle = alternatingRowStyle;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = Color.FromArgb(226, 232, 240);
            dgvNhanVien.Location = new Point(24, 485);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 32;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(516, 250);
            dgvNhanVien.TabIndex = 13;
            // 
            // dgvTrangThai (Lưới 4 - Bottom Right)
            // 
            dgvTrangThai.AllowUserToAddRows = false;
            dgvTrangThai.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            dgvTrangThai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrangThai.BackgroundColor = Color.White;
            dgvTrangThai.BorderStyle = BorderStyle.FixedSingle;
            dgvTrangThai.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTrangThai.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTrangThai.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvTrangThai.ColumnHeadersHeight = 36;
            dgvTrangThai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTrangThai.DefaultCellStyle = defaultCellStyle;
            dgvTrangThai.AlternatingRowsDefaultCellStyle = alternatingRowStyle;
            dgvTrangThai.EnableHeadersVisualStyles = false;
            dgvTrangThai.GridColor = Color.FromArgb(226, 232, 240);
            dgvTrangThai.Location = new Point(564, 485);
            dgvTrangThai.Name = "dgvTrangThai";
            dgvTrangThai.ReadOnly = true;
            dgvTrangThai.RowHeadersVisible = false;
            dgvTrangThai.RowHeadersWidth = 51;
            dgvTrangThai.RowTemplate.Height = 32;
            dgvTrangThai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrangThai.Size = new Size(516, 250);
            dgvTrangThai.TabIndex = 14;
            // 
            // FrmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1104, 760);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnThongKe);
            Controls.Add(label6);
            Controls.Add(lblTrungBinh);
            Controls.Add(label5);
            Controls.Add(lblDonDangPhucVu);
            Controls.Add(label4);
            Controls.Add(lblSoDon);
            Controls.Add(label3);
            Controls.Add(lblDoanhThu);
            Controls.Add(label2);
            Controls.Add(dtpDenNgay);
            Controls.Add(label1);
            Controls.Add(dtpTuNgay);
            Controls.Add(btnNamNay);
            Controls.Add(btnThangNay);
            Controls.Add(btnHomNay);
            Controls.Add(dgvTrangThai);
            Controls.Add(dgvNhanVien);
            Controls.Add(dgvMonBanChay);
            Controls.Add(dgvDoanhThu);
            MinimumSize = new Size(1000, 720);
            Name = "FrmThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo Thống kê";
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