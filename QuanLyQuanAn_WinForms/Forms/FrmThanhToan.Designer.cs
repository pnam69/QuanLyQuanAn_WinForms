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
            cboPhuongThuc = new ComboBox();
            lblTongTien = new Label();
            lblPhuongThuc = new Label();
            btnThanhToan = new Button();
            lblMaDon = new Label();
            btnHuy = new Button();
            dgvChiTietThanhToan = new DataGridView();
            picQRCode = new PictureBox();
            lblBan = new Label();
            lblNoiDungQR = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietThanhToan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQRCode).BeginInit();
            SuspendLayout();
            // 
            // cboPhuongThuc
            // 
            cboPhuongThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhuongThuc.FormattingEnabled = true;
            cboPhuongThuc.Location = new Point(462, 60);
            cboPhuongThuc.Name = "cboPhuongThuc";
            cboPhuongThuc.Size = new Size(194, 28);
            cboPhuongThuc.TabIndex = 51;
            cboPhuongThuc.SelectedIndexChanged += cboPhuongThuc_SelectedIndexChanged;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(33, 68);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 20);
            lblTongTien.TabIndex = 50;
            lblTongTien.Text = "Tổng tiền";
            // 
            // lblPhuongThuc
            // 
            lblPhuongThuc.AutoSize = true;
            lblPhuongThuc.Location = new Point(462, 9);
            lblPhuongThuc.Name = "lblPhuongThuc";
            lblPhuongThuc.Size = new Size(93, 20);
            lblPhuongThuc.TabIndex = 48;
            lblPhuongThuc.Text = "Phương thức";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(43, 382);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 29);
            btnThanhToan.TabIndex = 46;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // lblMaDon
            // 
            lblMaDon.AutoSize = true;
            lblMaDon.Location = new Point(33, 9);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Size = new Size(60, 20);
            lblMaDon.TabIndex = 41;
            lblMaDon.Text = "Mã đơn";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(291, 382);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 52;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // dgvChiTietThanhToan
            // 
            dgvChiTietThanhToan.AllowUserToAddRows = false;
            dgvChiTietThanhToan.AllowUserToDeleteRows = false;
            dgvChiTietThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietThanhToan.Location = new Point(33, 108);
            dgvChiTietThanhToan.MultiSelect = false;
            dgvChiTietThanhToan.Name = "dgvChiTietThanhToan";
            dgvChiTietThanhToan.ReadOnly = true;
            dgvChiTietThanhToan.RowHeadersWidth = 51;
            dgvChiTietThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietThanhToan.Size = new Size(417, 249);
            dgvChiTietThanhToan.TabIndex = 53;
            // 
            // picQRCode
            // 
            picQRCode.Location = new Point(462, 108);
            picQRCode.Name = "picQRCode";
            picQRCode.Size = new Size(243, 243);
            picQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            picQRCode.TabIndex = 54;
            picQRCode.TabStop = false;
            // 
            // lblBan
            // 
            lblBan.AutoSize = true;
            lblBan.Location = new Point(33, 39);
            lblBan.Name = "lblBan";
            lblBan.Size = new Size(34, 20);
            lblBan.TabIndex = 55;
            lblBan.Text = "Bàn";
            // 
            // lblNoiDungQR
            // 
            lblNoiDungQR.AutoSize = true;
            lblNoiDungQR.Location = new Point(462, 382);
            lblNoiDungQR.Name = "lblNoiDungQR";
            lblNoiDungQR.Size = new Size(29, 20);
            lblNoiDungQR.TabIndex = 56;
            lblNoiDungQR.Text = "QR";
            // 
            // FrmThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 423);
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
            Name = "FrmThanhToan";
            Text = "FrmThanhToan";
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