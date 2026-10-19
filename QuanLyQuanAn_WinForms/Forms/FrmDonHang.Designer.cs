using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmDonHang
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

            label3 = new Label();
            cboBan = new ComboBox();
            lblTrangThai = new Label();
            dgvDonHang = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboNhanVien = new ComboBox();
            lblTenDM = new Label();
            cboTrangThai = new ComboBox();
            btnChiTiet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // lblTenDM (Nhãn Bàn)
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDM.ForeColor = Color.FromArgb(51, 65, 85);
            lblTenDM.Location = new Point(24, 30);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(45, 23);
            lblTenDM.TabIndex = 24;
            lblTenDM.Text = "Bàn:";
            // 
            // cboBan
            // 
            cboBan.BackColor = Color.White;
            cboBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBan.FlatStyle = FlatStyle.Standard;
            cboBan.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboBan.ForeColor = Color.FromArgb(15, 23, 42);
            cboBan.FormattingEnabled = true;
            cboBan.Location = new Point(78, 26);
            cboBan.Name = "cboBan";
            cboBan.Size = new Size(190, 31);
            cboBan.TabIndex = 33;
            // 
            // label3 (Nhãn Nhân viên)
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(51, 65, 85);
            label3.Location = new Point(296, 30);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 37;
            label3.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.White;
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FlatStyle = FlatStyle.Standard;
            cboNhanVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboNhanVien.ForeColor = Color.FromArgb(15, 23, 42);
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(398, 26);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(220, 31);
            cboNhanVien.TabIndex = 26;
            // 
            // lblTrangThai (Nhãn Trạng thái)
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.FromArgb(51, 65, 85);
            lblTrangThai.Location = new Point(646, 30);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(92, 23);
            lblTrangThai.TabIndex = 32;
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
            cboTrangThai.Location = new Point(748, 26);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(188, 31);
            cboTrangThai.TabIndex = 39;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(16, 185, 129);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(24, 78);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(135, 38);
            btnThem.TabIndex = 27;
            btnThem.Text = "➕ Tạo đơn";
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
            btnSua.Location = new Point(172, 78);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 38);
            btnSua.TabIndex = 28;
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
            btnXoa.Location = new Point(310, 78);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 38);
            btnXoa.TabIndex = 29;
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
            btnLamMoi.Location = new Point(448, 78);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(135, 38);
            btnLamMoi.TabIndex = 30;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnChiTiet
            // 
            btnChiTiet.BackColor = Color.FromArgb(37, 99, 235);
            btnChiTiet.Cursor = Cursors.Hand;
            btnChiTiet.FlatAppearance.BorderSize = 0;
            btnChiTiet.FlatStyle = FlatStyle.Flat;
            btnChiTiet.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChiTiet.ForeColor = Color.White;
            btnChiTiet.Location = new Point(596, 78);
            btnChiTiet.Name = "btnChiTiet";
            btnChiTiet.Size = new Size(155, 38);
            btnChiTiet.TabIndex = 40;
            btnChiTiet.Text = "📋 Chi tiết đơn";
            btnChiTiet.UseVisualStyleBackColor = false;
            btnChiTiet.Click += btnChiTiet_Click;
            // 
            // dgvDonHang
            // 
            dgvDonHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.BackgroundColor = Color.White;
            dgvDonHang.BorderStyle = BorderStyle.FixedSingle;
            dgvDonHang.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDonHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnHeaderStyle.BackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Padding = new Padding(6);
            columnHeaderStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.SelectionForeColor = Color.White;
            dgvDonHang.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvDonHang.ColumnHeadersHeight = 42;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            defaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            defaultCellStyle.Padding = new Padding(6, 2, 6, 2);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvDonHang.DefaultCellStyle = defaultCellStyle;

            alternatingRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvDonHang.AlternatingRowsDefaultCellStyle = alternatingRowStyle;

            dgvDonHang.EnableHeadersVisualStyles = false;
            dgvDonHang.GridColor = Color.FromArgb(226, 232, 240);
            dgvDonHang.Location = new Point(24, 134);
            dgvDonHang.MultiSelect = false;
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.ReadOnly = true;
            dgvDonHang.RowHeadersVisible = false;
            dgvDonHang.RowHeadersWidth = 51;
            dgvDonHang.RowTemplate.Height = 36;
            dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDonHang.Size = new Size(912, 402);
            dgvDonHang.TabIndex = 31;
            dgvDonHang.CellClick += dgvDonHang_CellClick;
            // 
            // FrmDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(960, 560);
            Controls.Add(btnChiTiet);
            Controls.Add(cboTrangThai);
            Controls.Add(label3);
            Controls.Add(cboBan);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvDonHang);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboNhanVien);
            Controls.Add(lblTenDM);
            MinimumSize = new Size(885, 492);
            Name = "FrmDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đơn hàng";
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cboBan;
        private Label lblTrangThai;
        private DataGridView dgvDonHang;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboNhanVien;
        private Label lblTenDM;
        private ComboBox cboTrangThai;
        private Button btnChiTiet;
    }
}