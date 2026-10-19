using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmDanhMuc
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

            lblTenDM = new Label();
            txtTenDM = new TextBox();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvDanhMuc = new DataGridView();
            lblTrangThai = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // lblTenDM
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDM.ForeColor = Color.FromArgb(51, 65, 85);
            lblTenDM.Location = new Point(24, 30);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(125, 23);
            lblTenDM.TabIndex = 0;
            lblTenDM.Text = "Tên danh mục:";
            // 
            // txtTenDM
            // 
            txtTenDM.BackColor = Color.White;
            txtTenDM.BorderStyle = BorderStyle.FixedSingle;
            txtTenDM.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDM.ForeColor = Color.FromArgb(15, 23, 42);
            txtTenDM.Location = new Point(158, 27);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(265, 30);
            txtTenDM.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.FromArgb(51, 65, 85);
            lblTrangThai.Location = new Point(455, 30);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(92, 23);
            lblTrangThai.TabIndex = 8;
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
            cboTrangThai.Location = new Point(558, 26);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(218, 31);
            cboTrangThai.TabIndex = 2;
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
            btnThem.Size = new Size(130, 38);
            btnThem.TabIndex = 3;
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
            btnSua.Location = new Point(168, 78);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 38);
            btnSua.TabIndex = 4;
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
            btnXoa.Location = new Point(312, 78);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 38);
            btnXoa.TabIndex = 5;
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
            btnLamMoi.Location = new Point(456, 78);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 38);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.BackgroundColor = Color.White;
            dgvDanhMuc.BorderStyle = BorderStyle.FixedSingle;
            dgvDanhMuc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhMuc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnHeaderStyle.BackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Padding = new Padding(6);
            columnHeaderStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.SelectionForeColor = Color.White;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvDanhMuc.ColumnHeadersHeight = 42;
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            defaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            defaultCellStyle.Padding = new Padding(6, 2, 6, 2);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvDanhMuc.DefaultCellStyle = defaultCellStyle;

            alternatingRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvDanhMuc.AlternatingRowsDefaultCellStyle = alternatingRowStyle;

            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.GridColor = Color.FromArgb(226, 232, 240);
            dgvDanhMuc.Location = new Point(24, 136);
            dgvDanhMuc.MultiSelect = false;
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.RowTemplate.Height = 36;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.Size = new Size(752, 340);
            dgvDanhMuc.TabIndex = 7;
            dgvDanhMuc.CellClick += dgvDanhMuc_CellClick;
            // 
            // FrmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(800, 500);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvDanhMuc);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboTrangThai);
            Controls.Add(txtTenDM);
            Controls.Add(lblTenDM);
            MinimumSize = new Size(760, 460);
            Name = "FrmDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục món ăn";
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenDM;
        private TextBox txtTenDM;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvDanhMuc;
        private Label lblTrangThai;
    }
}