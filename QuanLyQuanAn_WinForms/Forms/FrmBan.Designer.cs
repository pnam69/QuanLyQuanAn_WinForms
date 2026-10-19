using System.Drawing;
using System.Windows.Forms;

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
            // lblTieuDe (Header Banner)
            // 
            lblTieuDe.AutoSize = false;
            lblTieuDe.BackColor = Color.FromArgb(30, 41, 59);
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.White;
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1182, 52);
            lblTieuDe.TabIndex = 42;
            lblTieuDe.Text = "QUẢN LÝ SƠ ĐỒ BÀN ĂN";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlToolbar (Thanh công cụ điều khiển)
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.BorderStyle = BorderStyle.FixedSingle;
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
            pnlToolbar.Location = new Point(0, 52);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Padding = new Padding(15, 10, 15, 10);
            pnlToolbar.Size = new Size(1182, 114);
            pnlToolbar.TabIndex = 43;
            // 
            // lblTang
            // 
            lblTang.AutoSize = true;
            lblTang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTang.ForeColor = Color.FromArgb(51, 65, 85);
            lblTang.Location = new Point(28, 20);
            lblTang.Name = "lblTang";
            lblTang.Size = new Size(115, 23);
            lblTang.TabIndex = 44;
            lblTang.Text = "Khu vực / Tầng:";
            // 
            // cboTang
            // 
            cboTang.BackColor = Color.FromArgb(248, 250, 252);
            cboTang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTang.FlatStyle = FlatStyle.Standard;
            cboTang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTang.ForeColor = Color.FromArgb(15, 23, 42);
            cboTang.FormattingEnabled = true;
            cboTang.Location = new Point(168, 16);
            cboTang.Name = "cboTang";
            cboTang.Size = new Size(190, 31);
            cboTang.TabIndex = 52;
            cboTang.SelectedIndexChanged += cboTang_SelectedIndexChanged;
            // 
            // btnThemTang
            // 
            btnThemTang.BackColor = Color.FromArgb(16, 185, 129);
            btnThemTang.Cursor = Cursors.Hand;
            btnThemTang.FlatAppearance.BorderSize = 0;
            btnThemTang.FlatStyle = FlatStyle.Flat;
            btnThemTang.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemTang.ForeColor = Color.White;
            btnThemTang.Location = new Point(385, 14);
            btnThemTang.Name = "btnThemTang";
            btnThemTang.Size = new Size(125, 36);
            btnThemTang.TabIndex = 56;
            btnThemTang.Text = "➕ Thêm tầng";
            btnThemTang.UseVisualStyleBackColor = false;
            btnThemTang.Click += btnThemTang_Click;
            // 
            // btnSuaTang
            // 
            btnSuaTang.BackColor = Color.FromArgb(245, 158, 11);
            btnSuaTang.Cursor = Cursors.Hand;
            btnSuaTang.FlatAppearance.BorderSize = 0;
            btnSuaTang.FlatStyle = FlatStyle.Flat;
            btnSuaTang.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSuaTang.ForeColor = Color.White;
            btnSuaTang.Location = new Point(522, 14);
            btnSuaTang.Name = "btnSuaTang";
            btnSuaTang.Size = new Size(120, 36);
            btnSuaTang.TabIndex = 58;
            btnSuaTang.Text = "✏️ Sửa tầng";
            btnSuaTang.UseVisualStyleBackColor = false;
            btnSuaTang.Click += btnSuaTang_Click;
            // 
            // btnXoaTang
            // 
            btnXoaTang.BackColor = Color.FromArgb(239, 68, 68);
            btnXoaTang.Cursor = Cursors.Hand;
            btnXoaTang.FlatAppearance.BorderSize = 0;
            btnXoaTang.FlatStyle = FlatStyle.Flat;
            btnXoaTang.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTang.ForeColor = Color.White;
            btnXoaTang.Location = new Point(654, 14);
            btnXoaTang.Name = "btnXoaTang";
            btnXoaTang.Size = new Size(120, 36);
            btnXoaTang.TabIndex = 57;
            btnXoaTang.Text = "🗑️ Xóa tầng";
            btnXoaTang.UseVisualStyleBackColor = false;
            btnXoaTang.Click += btnXoaTang_Click;
            // 
            // chkChinhSua
            // 
            chkChinhSua.AutoSize = true;
            chkChinhSua.Cursor = Cursors.Hand;
            chkChinhSua.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkChinhSua.ForeColor = Color.FromArgb(37, 99, 235);
            chkChinhSua.Location = new Point(28, 68);
            chkChinhSua.Name = "chkChinhSua";
            chkChinhSua.Size = new Size(216, 27);
            chkChinhSua.TabIndex = 44;
            chkChinhSua.Text = "🛠️ Chỉnh sửa sơ đồ bàn";
            chkChinhSua.UseVisualStyleBackColor = true;
            chkChinhSua.CheckedChanged += chkChinhSua_CheckedChanged;
            // 
            // btnThemBan
            // 
            btnThemBan.BackColor = Color.FromArgb(37, 99, 235);
            btnThemBan.Cursor = Cursors.Hand;
            btnThemBan.FlatAppearance.BorderSize = 0;
            btnThemBan.FlatStyle = FlatStyle.Flat;
            btnThemBan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemBan.ForeColor = Color.White;
            btnThemBan.Location = new Point(385, 62);
            btnThemBan.Name = "btnThemBan";
            btnThemBan.Size = new Size(125, 36);
            btnThemBan.TabIndex = 44;
            btnThemBan.Text = "➕ Thêm bàn";
            btnThemBan.UseVisualStyleBackColor = false;
            btnThemBan.Click += btnThemBan_Click;
            // 
            // btnXoaBan
            // 
            btnXoaBan.BackColor = Color.FromArgb(225, 29, 72);
            btnXoaBan.Cursor = Cursors.Hand;
            btnXoaBan.FlatAppearance.BorderSize = 0;
            btnXoaBan.FlatStyle = FlatStyle.Flat;
            btnXoaBan.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaBan.ForeColor = Color.White;
            btnXoaBan.Location = new Point(522, 62);
            btnXoaBan.Name = "btnXoaBan";
            btnXoaBan.Size = new Size(120, 36);
            btnXoaBan.TabIndex = 53;
            btnXoaBan.Text = "🗑️ Xóa bàn";
            btnXoaBan.UseVisualStyleBackColor = false;
            btnXoaBan.Click += btnXoaBan_Click;
            // 
            // btnLuuViTri
            // 
            btnLuuViTri.BackColor = Color.FromArgb(79, 70, 229);
            btnLuuViTri.Cursor = Cursors.Hand;
            btnLuuViTri.FlatAppearance.BorderSize = 0;
            btnLuuViTri.FlatStyle = FlatStyle.Flat;
            btnLuuViTri.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuViTri.ForeColor = Color.White;
            btnLuuViTri.Location = new Point(654, 62);
            btnLuuViTri.Name = "btnLuuViTri";
            btnLuuViTri.Size = new Size(120, 36);
            btnLuuViTri.TabIndex = 54;
            btnLuuViTri.Text = "💾 Lưu vị trí";
            btnLuuViTri.UseVisualStyleBackColor = false;
            btnLuuViTri.Click += btnLuuViTri_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(100, 116, 139);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(786, 62);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(125, 36);
            btnLamMoi.TabIndex = 55;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // pnlBan (Vùng không gian hiển thị sơ đồ bàn)
            // 
            pnlBan.AutoScroll = true;
            pnlBan.BackColor = Color.FromArgb(241, 245, 249);
            pnlBan.Controls.Add(panel1);
            pnlBan.Controls.Add(button1);
            pnlBan.Controls.Add(button2);
            pnlBan.Controls.Add(button3);
            pnlBan.Dock = DockStyle.Fill;
            pnlBan.Location = new Point(0, 166);
            pnlBan.Name = "pnlBan";
            pnlBan.Padding = new Padding(20);
            pnlBan.Size = new Size(1182, 495);
            pnlBan.TabIndex = 44;
            // 
            // panel1 (Giữ lại biến để tránh lỗi biên dịch nhưng ẩn đi để không đè lên pnlBan)
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 55;
            panel1.Visible = false;
            // 
            // button1 (Ẩn control thừa)
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(0, 0);
            button1.TabIndex = 58;
            button1.Text = "Lưu vị trí";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // button2 (Ẩn control thừa)
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(0, 0);
            button2.TabIndex = 57;
            button2.Text = "Xóa bàn";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            // 
            // button3 (Ẩn control thừa)
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 56;
            button3.Text = "Thêm bàn";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            // 
            // lblThongKe (Thanh trạng thái dưới cùng)
            // 
            lblThongKe.AutoSize = false;
            lblThongKe.BackColor = Color.FromArgb(30, 41, 59);
            lblThongKe.Dock = DockStyle.Bottom;
            lblThongKe.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKe.ForeColor = Color.FromArgb(248, 250, 252);
            lblThongKe.Location = new Point(0, 661);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(1182, 42);
            lblThongKe.TabIndex = 45;
            lblThongKe.Text = "🟢 Trống: 0   |   🔴 Đang phục vụ: 0   |   🟡 Đã đặt: 0";
            lblThongKe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlBan);
            Controls.Add(pnlToolbar);
            Controls.Add(lblTieuDe);
            Controls.Add(lblThongKe);
            MinimumSize = new Size(1000, 650);
            Name = "FrmBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sơ đồ bàn ăn";
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlBan.ResumeLayout(false);
            ResumeLayout(false);
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