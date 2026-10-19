using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmThanhToan
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

            lblMaDon = new Label();
            lblBan = new Label();
            lblTongTien = new Label();
            dgvChiTietThanhToan = new DataGridView();
            lblPhuongThuc = new Label();
            cboPhuongThuc = new ComboBox();
            picQRCode = new PictureBox();
            lblNoiDungQR = new Label();
            btnThanhToan = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietThanhToan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
            SuspendLayout();
            // 
            // lblMaDon (Mã đơn hàng)
            // 
            lblMaDon.AutoSize = true;
            lblMaDon.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaDon.ForeColor = Color.FromArgb(30, 41, 59);
            lblMaDon.Location = new Point(24, 22);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Size = new Size(111, 24);
            lblMaDon.TabIndex = 41;
            lblMaDon.Text = "📋 Mã đơn: --";
            // 
            // lblBan (Tên bàn)
            // 
            lblBan.AutoSize = true;
            lblBan.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBan.ForeColor = Color.FromArgb(30, 41, 59);
            lblBan.Location = new Point(24, 54);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(78, 24);
            lblBan.TabIndex = 55;
            lblBan.Text = "🪑 Bàn: --";
            // 
            // lblTongTien (Tổng tiền cần thanh toán)
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.FromArgb(220, 38, 38);
            lblTongTien.Location = new Point(24, 88);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(181, 32);
            lblTongTien.TabIndex = 50;
            lblTongTien.Text = "💰 Tổng tiền: 0 đ";
            // 
            // dgvChiTietThanhToan (Bảng chi tiết món)
            // 
            dgvChiTietThanhToan.AllowUserToAddRows = false;
            dgvChiTietThanhToan.AllowUserToDeleteRows = false;
            dgvChiTietThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvChiTietThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietThanhToan.BackgroundColor = Color.White;
            dgvChiTietThanhToan.BorderStyle = BorderStyle.FixedSingle;
            dgvChiTietThanhToan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvChiTietThanhToan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnHeaderStyle.BackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Padding = new Padding(4);
            columnHeaderStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.SelectionForeColor = Color.White;
            dgvChiTietThanhToan.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvChiTietThanhToan.ColumnHeadersHeight = 38;
            dgvChiTietThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            defaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            defaultCellStyle.Padding = new Padding(4, 2, 4, 2);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvChiTietThanhToan.DefaultCellStyle = defaultCellStyle;

            alternatingRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvChiTietThanhToan.AlternatingRowsDefaultCellStyle = alternatingRowStyle;

            dgvChiTietThanhToan.EnableHeadersVisualStyles = false;
            dgvChiTietThanhToan.GridColor = Color.FromArgb(226, 232, 240);
            dgvChiTietThanhToan.Location = new Point(24, 134);
            dgvChiTietThanhToan.MultiSelect = false;
            dgvChiTietThanhToan.Name = "dgvChiTietThanhToan";
            dgvChiTietThanhToan.ReadOnly = true;
            dgvChiTietThanhToan.RowHeadersVisible = false;
            dgvChiTietThanhToan.RowHeadersWidth = 51;
            dgvChiTietThanhToan.RowTemplate.Height = 32;
            dgvChiTietThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietThanhToan.Size = new Size(420, 275);
            dgvChiTietThanhToan.TabIndex = 53;
            // 
            // lblPhuongThuc (Nhãn Phương thức thanh toán)
            // 
            lblPhuongThuc.AutoSize = true;
            lblPhuongThuc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhuongThuc.ForeColor = Color.FromArgb(51, 65, 85);
            lblPhuongThuc.Location = new Point(468, 22);
            lblPhuongThuc.Name = "lblPhuongThuc";
            lblPhuongThuc.Size = new Size(189, 23);
            lblPhuongThuc.TabIndex = 48;
            lblPhuongThuc.Text = "💳 Phương thức thanh toán";
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.BackColor = Color.White;
            cboPhuongThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhuongThuc.FlatStyle = FlatStyle.Standard;
            cboPhuongThuc.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPhuongThuc.ForeColor = Color.FromArgb(15, 23, 42);
            cboPhuongThuc.FormattingEnabled = true;
            cboPhuongThuc.Location = new Point(468, 52);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(248, 31);
            cboPhuongThuc.TabIndex = 51;
            cboPhuongThuc.SelectedIndexChanged += cboPhuongThuc_SelectedIndexChanged;
            // 
            // picQRCode (Khung ảnh mã QR chuyển khoản)
            // 
            picQRCode.BackColor = Color.White;
            picQRCode.BorderStyle = BorderStyle.FixedSingle;
            picQRCode.Location = new Point(468, 96);
            picQRCode.Name = "picQRCode";
            picQRCode.Size = new Size(248, 248);
            picQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            picQRCode.TabIndex = 54;
            picQRCode.TabStop = false;
            // 
            // lblNoiDungQR (Hướng dẫn / Nội dung QR)
            // 
            lblNoiDungQR.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoiDungQR.ForeColor = Color.FromArgb(71, 85, 105);
            lblNoiDungQR.Location = new Point(468, 350);
            lblNoiDungQR.Name = "lblNoiDungQR";
            lblNoiDungQR.Size = new Size(248, 59);
            lblNoiDungQR.TabIndex = 56;
            lblNoiDungQR.Text = "Quét mã QR để thanh toán đơn hàng";
            lblNoiDungQR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnThanhToan (Nút xác nhận thanh toán)
            // 
            btnThanhToan.BackColor = Color.FromArgb(16, 185, 129);
            btnThanhToan.Cursor = Cursors.Hand;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(24, 422);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(200, 42);
            btnThanhToan.TabIndex = 46;
            btnThanhToan.Text = "✅ Xác nhận thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // btnHuy (Nút hủy / đóng)
            // 
            btnHuy.BackColor = Color.FromArgb(100, 116, 139);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(238, 422);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(206, 42);
            btnHuy.TabIndex = 52;
            btnHuy.Text = "✖ Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(744, 485);
            Controls.Add(lblNoiDungQR);
            Controls.Add(lblBan);
            Controls.Add(picQRCode);
            Controls.Add(dgvChiTietThanhToan);
            Controls.Add(btnHuy);
            Controls.Add(cboPhuongThuc);
            Controls.Add(lblTongTien);
            Controls.Add(lblPhuongThuc);
            Controls.Add(btnThanhToan);
            Controls.Add(lblMaDon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(740, 520);
            Name = "FrmThanhToan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thanh toán hóa đơn";
            ((System.ComponentModel.ISupportInitialize)dgvChiTietThanhToan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChiTiet;
        private ComboBox cboPhuongThuc;
        private Label lblTongTien;
        private Label lblPhuongThuc;
        private DataGridView dgvDonHang;
        private Button btnThanhToan;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblMaDon;
        private Button btnHuy;
        private DataGridView dgvChiTietThanhToan;
        private PictureBox picQRCode;
        private Label lblBan;
        private Label lblNoiDungQR;
    }
}