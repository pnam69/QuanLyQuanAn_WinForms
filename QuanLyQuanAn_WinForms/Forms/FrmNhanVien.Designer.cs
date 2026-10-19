using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmNhanVien
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

            lblTrangThai = new Label();
            dgvNhanVien = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboTrangThai = new ComboBox();
            txtHoTen = new TextBox();
            lblTenDM = new Label();
            label1 = new Label();
            cboVaiTro = new ComboBox();
            txtMatKhau = new TextBox();
            label2 = new Label();
            txtTaiKhoan = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // lblTenDM (Nhãn Họ tên - Cột 1, Hàng 1)
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDM.ForeColor = Color.FromArgb(51, 65, 85);
            lblTenDM.Location = new Point(24, 28);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(66, 23);
            lblTenDM.TabIndex = 9;
            lblTenDM.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.White;
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.ForeColor = Color.FromArgb(15, 23, 42);
            txtHoTen.Location = new Point(125, 25);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(260, 30);
            txtHoTen.TabIndex = 10;
            // 
            // label3 (Nhãn Tài khoản - Cột 1, Hàng 2)
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(51, 65, 85);
            label3.Location = new Point(24, 76);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 22;
            label3.Text = "Tài khoản:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = Color.White;
            txtTaiKhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTaiKhoan.ForeColor = Color.FromArgb(15, 23, 42);
            txtTaiKhoan.Location = new Point(125, 73);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(260, 30);
            txtTaiKhoan.TabIndex = 23;
            // 
            // label2 (Nhãn Mật khẩu - Cột 1, Hàng 3)
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Location = new Point(24, 124);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 20;
            label2.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.FromArgb(15, 23, 42);
            txtMatKhau.Location = new Point(125, 121);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(260, 30);
            txtMatKhau.TabIndex = 21;
            // 
            // label1 (Nhãn Vai trò - Cột 2, Hàng 1)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 65, 85);
            label1.Location = new Point(430, 28);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 19;
            label1.Text = "Vai trò:";
            // 
            // cboVaiTro
            // 
            cboVaiTro.BackColor = Color.White;
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVaiTro.FlatStyle = FlatStyle.Standard;
            cboVaiTro.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboVaiTro.ForeColor = Color.FromArgb(15, 23, 42);
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(530, 24);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(260, 31);
            cboVaiTro.TabIndex = 18;
            // 
            // lblTrangThai (Nhãn Trạng thái - Cột 2, Hàng 2)
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.FromArgb(51, 65, 85);
            lblTrangThai.Location = new Point(430, 76);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(92, 23);
            lblTrangThai.TabIndex = 17;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.BackColor = Color.White;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FlatStyle = FlatStyle.Standard;
            cboTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTrangThai.ForeColor = Color.FromArgb(15, 23, 42);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(530, 72);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(260, 31);
            cboTrangThai.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(16, 185, 129);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(24, 172);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 38);
            btnThem.TabIndex = 12;
            btnThem.Text = "➕ Thêm";
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
            btnSua.Location = new Point(168, 172);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 38);
            btnSua.TabIndex = 13;
            btnSua.Text = "✏️ Sửa";
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
            btnXoa.Location = new Point(312, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 38);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(100, 116, 139);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(456, 172);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 38);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.FixedSingle;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnHeaderStyle.BackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Padding = new Padding(6);
            columnHeaderStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.SelectionForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvNhanVien.ColumnHeadersHeight = 42;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            defaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            defaultCellStyle.Padding = new Padding(6, 2, 6, 2);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvNhanVien.DefaultCellStyle = defaultCellStyle;

            alternatingRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvNhanVien.AlternatingRowsDefaultCellStyle = alternatingRowStyle;

            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = Color.FromArgb(226, 232, 240);
            dgvNhanVien.Location = new Point(24, 228);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 36;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(791, 310);
            dgvNhanVien.TabIndex = 16;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // FrmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(840, 560);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label3);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboVaiTro);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboTrangThai);
            Controls.Add(txtHoTen);
            Controls.Add(lblTenDM);
            MinimumSize = new Size(810, 500);
            Name = "FrmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrangThai;
        private DataGridView dgvNhanVien;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboTrangThai;
        private TextBox txtHoTen;
        private Label lblTenDM;
        private Label label1;
        private ComboBox cboVaiTro;
        private TextBox txtMatKhau;
        private Label label2;
        private TextBox txtTaiKhoan;
        private Label label3;
    }
}