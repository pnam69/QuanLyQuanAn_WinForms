using System.Drawing;
using System.Windows.Forms;

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
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle alternatingRowStyle = new DataGridViewCellStyle();

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
            // lblMaDon (Thanh tiêu đề hiển thị Mã đơn hàng)
            // 
            lblMaDon.AutoSize = false;
            lblMaDon.BackColor = Color.FromArgb(30, 41, 59);
            lblMaDon.Dock = DockStyle.Top;
            lblMaDon.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaDon.ForeColor = Color.White;
            lblMaDon.Location = new Point(0, 0);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Padding = new Padding(20, 0, 0, 0);
            lblMaDon.Size = new Size(860, 50);
            lblMaDon.TabIndex = 40;
            lblMaDon.Text = "📋 CHI TIẾT ĐƠN HÀNG - Mã đơn:";
            lblMaDon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTrangThai (Nhãn Chọn món ăn)
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.FromArgb(51, 65, 85);
            lblTrangThai.Location = new Point(24, 72);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(71, 23);
            lblTrangThai.TabIndex = 47;
            lblTrangThai.Text = "Món ăn:";
            // 
            // cboMonAn
            // 
            cboMonAn.BackColor = Color.White;
            cboMonAn.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMonAn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMonAn.ForeColor = Color.FromArgb(15, 23, 42);
            cboMonAn.FormattingEnabled = true;
            cboMonAn.Location = new Point(110, 68);
            cboMonAn.Name = "cboMonAn";
            cboMonAn.Size = new Size(330, 31);
            cboMonAn.TabIndex = 48;
            // 
            // label1 (Nhãn Số lượng)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 65, 85);
            label1.Location = new Point(475, 72);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 51;
            label1.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            numSoLuong.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numSoLuong.ForeColor = Color.FromArgb(15, 23, 42);
            numSoLuong.Location = new Point(570, 68);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(130, 31);
            numSoLuong.TabIndex = 52;
            numSoLuong.TextAlign = HorizontalAlignment.Center;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(16, 185, 129);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(24, 116);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 38);
            btnThem.TabIndex = 42;
            btnThem.Text = "➕ Thêm món";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(245, 158, 11);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(172, 116);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(135, 38);
            btnSua.TabIndex = 43;
            btnSua.Text = "✏️ Cập nhật";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(239, 68, 68);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(320, 116);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(135, 38);
            btnXoa.TabIndex = 44;
            btnXoa.Text = "🗑️ Xóa món";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvChiTiet (Bảng danh sách món trong đơn)
            // 
            dgvChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.BorderStyle = BorderStyle.FixedSingle;
            dgvChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiTiet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnHeaderStyle.BackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Padding = new Padding(6);
            columnHeaderStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.SelectionForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvChiTiet.ColumnHeadersHeight = 42;
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            defaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            defaultCellStyle.Padding = new Padding(6, 2, 6, 2);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvChiTiet.DefaultCellStyle = defaultCellStyle;

            alternatingRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvChiTiet.AlternatingRowsDefaultCellStyle = alternatingRowStyle;

            dgvChiTiet.EnableHeadersVisualStyles = false;
            dgvChiTiet.GridColor = Color.FromArgb(226, 232, 240);
            dgvChiTiet.Location = new Point(24, 170);
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersVisible = false;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 36;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(812, 325);
            dgvChiTiet.TabIndex = 56;
            dgvChiTiet.CellClick += dgvChiTiet_CellClick;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.FromArgb(220, 38, 38);
            lblTongTien.Location = new Point(24, 518);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(122, 31);
            lblTongTien.TabIndex = 54;
            lblTongTien.Text = "Tổng tiền: 0 đ";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThanhToan.BackColor = Color.FromArgb(37, 99, 235);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(546, 512);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(160, 42);
            btnThanhToan.TabIndex = 53;
            btnThanhToan.Text = "💳 Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDong.BackColor = Color.FromArgb(100, 116, 139);
            btnDong.Cursor = Cursors.Hand;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(718, 512);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(118, 42);
            btnDong.TabIndex = 55;
            btnDong.Text = "✖ Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // FrmChiTietDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(860, 575);
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
            MinimumSize = new Size(780, 520);
            Name = "FrmChiTietDonHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết đơn hàng";
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