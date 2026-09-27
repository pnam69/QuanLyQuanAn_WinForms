namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmBan
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
            lblTieuDe = new Label();
            pnlToolbar = new Panel();
            btnSuaTang = new Button();
            btnXoaTang = new Button();
            btnThemTang = new Button();
            btnLamMoi = new Button();
            btnLuuViTri = new Button();
            btnXoaBan = new Button();
            btnThemBan = new Button();
            chkChinhSua = new CheckBox();
            cboTang = new ComboBox();
            lblTang = new Label();
            pnlBan = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblThongKe = new Label();
            pnlToolbar.SuspendLayout();
            pnlBan.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(302, 38);
            lblTieuDe.TabIndex = 42;
            lblTieuDe.Text = "QUẢN LÝ SƠ ĐỒ BÀN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlToolbar
            // 
            pnlToolbar.AutoScroll = true;
            pnlToolbar.BackColor = Color.WhiteSmoke;
            pnlToolbar.Controls.Add(btnSuaTang);
            pnlToolbar.Controls.Add(btnXoaTang);
            pnlToolbar.Controls.Add(btnThemTang);
            pnlToolbar.Controls.Add(btnLamMoi);
            pnlToolbar.Controls.Add(btnLuuViTri);
            pnlToolbar.Controls.Add(btnXoaBan);
            pnlToolbar.Controls.Add(btnThemBan);
            pnlToolbar.Controls.Add(chkChinhSua);
            pnlToolbar.Controls.Add(cboTang);
            pnlToolbar.Controls.Add(lblTang);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 38);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1182, 138);
            pnlToolbar.TabIndex = 43;
            // 
            // btnSuaTang
            // 
            btnSuaTang.Location = new Point(539, 27);
            btnSuaTang.Name = "btnSuaTang";
            btnSuaTang.Size = new Size(95, 34);
            btnSuaTang.TabIndex = 58;
            btnSuaTang.Text = "Sửa tầng";
            btnSuaTang.UseVisualStyleBackColor = true;
            btnSuaTang.Click += btnSuaTang_Click;
            // 
            // btnXoaTang
            // 
            btnXoaTang.Location = new Point(676, 27);
            btnXoaTang.Name = "btnXoaTang";
            btnXoaTang.Size = new Size(95, 34);
            btnXoaTang.TabIndex = 57;
            btnXoaTang.Text = "Xóa tầng";
            btnXoaTang.UseVisualStyleBackColor = true;
            btnXoaTang.Click += btnXoaTang_Click;
            // 
            // btnThemTang
            // 
            btnThemTang.Location = new Point(405, 27);
            btnThemTang.Name = "btnThemTang";
            btnThemTang.Size = new Size(95, 34);
            btnThemTang.TabIndex = 56;
            btnThemTang.Text = "Thêm tầng";
            btnThemTang.UseVisualStyleBackColor = true;
            btnThemTang.Click += btnThemTang_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(539, 79);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(95, 34);
            btnLamMoi.TabIndex = 55;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnLuuViTri
            // 
            btnLuuViTri.Location = new Point(810, 79);
            btnLuuViTri.Name = "btnLuuViTri";
            btnLuuViTri.Size = new Size(81, 34);
            btnLuuViTri.TabIndex = 54;
            btnLuuViTri.Text = "Lưu vị trí";
            btnLuuViTri.UseVisualStyleBackColor = true;
            btnLuuViTri.Click += btnLuuViTri_Click;
            // 
            // btnXoaBan
            // 
            btnXoaBan.Location = new Point(405, 79);
            btnXoaBan.Name = "btnXoaBan";
            btnXoaBan.Size = new Size(95, 34);
            btnXoaBan.TabIndex = 53;
            btnXoaBan.Text = "Xóa bàn";
            btnXoaBan.UseVisualStyleBackColor = true;
            btnXoaBan.Click += btnXoaBan_Click;
            // 
            // btnThemBan
            // 
            btnThemBan.Location = new Point(676, 79);
            btnThemBan.Name = "btnThemBan";
            btnThemBan.Size = new Size(95, 34);
            btnThemBan.TabIndex = 44;
            btnThemBan.Text = "Thêm bàn";
            btnThemBan.UseVisualStyleBackColor = true;
            btnThemBan.Click += btnThemBan_Click;
            // 
            // chkChinhSua
            // 
            chkChinhSua.AutoSize = true;
            chkChinhSua.Location = new Point(141, 85);
            chkChinhSua.Name = "chkChinhSua";
            chkChinhSua.Size = new Size(136, 24);
            chkChinhSua.TabIndex = 44;
            chkChinhSua.Text = "Chỉnh sửa sơ đồ";
            chkChinhSua.UseVisualStyleBackColor = true;
            chkChinhSua.CheckedChanged += chkChinhSua_CheckedChanged;
            // 
            // cboTang
            // 
            cboTang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTang.FormattingEnabled = true;
            cboTang.Location = new Point(231, 31);
            cboTang.Name = "cboTang";
            cboTang.Size = new Size(155, 28);
            cboTang.TabIndex = 52;
            cboTang.SelectedIndexChanged += cboTang_SelectedIndexChanged;
            // 
            // lblTang
            // 
            lblTang.AutoSize = true;
            lblTang.Location = new Point(141, 34);
            lblTang.Name = "lblTang";
            lblTang.Size = new Size(42, 20);
            lblTang.TabIndex = 44;
            lblTang.Text = "Tầng";
            // 
            // pnlBan
            // 
            pnlBan.Controls.Add(panel1);
            pnlBan.Controls.Add(button1);
            pnlBan.Controls.Add(button2);
            pnlBan.Controls.Add(button3);
            pnlBan.Dock = DockStyle.Fill;
            pnlBan.Location = new Point(0, 176);
            pnlBan.Name = "pnlBan";
            pnlBan.Size = new Size(1182, 527);
            pnlBan.TabIndex = 44;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 527);
            panel1.TabIndex = 55;
            // 
            // button1
            // 
            button1.Location = new Point(539, 27);
            button1.Name = "button1";
            button1.Size = new Size(81, 34);
            button1.TabIndex = 58;
            button1.Text = "Lưu vị trí";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(405, 79);
            button2.Name = "button2";
            button2.Size = new Size(95, 34);
            button2.TabIndex = 57;
            button2.Text = "Xóa bàn";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(405, 27);
            button3.Name = "button3";
            button3.Size = new Size(95, 34);
            button3.TabIndex = 56;
            button3.Text = "Thêm bàn";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblThongKe
            // 
            lblThongKe.AutoSize = true;
            lblThongKe.Dock = DockStyle.Bottom;
            lblThongKe.Location = new Point(0, 683);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(252, 20);
            lblThongKe.TabIndex = 45;
            lblThongKe.Text = "Trống: 0 | Đang phục vụ: 0 | Đã đặt: 0";
            lblThongKe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 703);
            Controls.Add(lblThongKe);
            Controls.Add(pnlBan);
            Controls.Add(pnlToolbar);
            Controls.Add(lblTieuDe);
            MinimumSize = new Size(1000, 650);
            Name = "FrmBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBan";
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlBan.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Panel pnlToolbar;
        private Label lblTang;
        private CheckBox chkChinhSua;
        private ComboBox cboTang;
        private Button btnThemBan;
        private Button btnLamMoi;
        private Button btnLuuViTri;
        private Button btnXoaBan;
        private Panel pnlBan;
        private Label lblThongKe;
        private Button btnSuaTang;
        private Button btnXoaTang;
        private Button btnThemTang;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}