using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmMonAn
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
            dgvMonAn = new DataGridView();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            cboDanhMuc = new ComboBox();
            txtTenMon = new TextBox();
            lblTenDM = new Label();
            numDonGia = new NumericUpDown();
            label1 = new Label();
            cboTrangThai = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            SuspendLayout();
            // 
            // lblTenDM (Nhãn Tên món - Hàng 1, Cột 1)
            // 
            lblTenDM.AutoSize = true;
            lblTenDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDM.ForeColor = Color.FromArgb(51, 65, 85);
            lblTenDM.Location = new Point(24, 28);
            lblTenDM.Name = "lblTenDM";
            lblTenDM.Size = new Size(82, 23);
            lblTenDM.TabIndex = 9;
            lblTenDM.Text = "Tên món:";
            // 
            // txtTenMon
            // 
            txtTenMon.BackColor = Color.White;
            txtTenMon.BorderStyle = BorderStyle.FixedSingle;
            txtTenMon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenMon.ForeColor = Color.FromArgb(15, 23, 42);
            txtTenMon.Location = new Point(125, 25);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(280, 30);
            txtTenMon.TabIndex = 10;
            // 
            // label3 (Nhãn Danh mục - Hàng 1, Cột 2)
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(51, 65, 85);
            label3.Location = new Point(445, 28);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 22;
            label3.Text = "Danh mục:";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.BackColor = Color.White;
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.FlatStyle = FlatStyle.Standard;
            cboDanhMuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDanhMuc.ForeColor = Color.FromArgb(15, 23, 42);
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(555, 24);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(260, 31);
            cboDanhMuc.TabIndex = 11;
            // 
            // lblTrangThai (Nhãn Đơn giá - Hàng 2, Cột 1)
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThai.ForeColor = Color.FromArgb(51, 65, 85);
            lblTrangThai.Location = new Point(24, 76);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(76, 23);
            lblTrangThai.TabIndex = 17;
            lblTrangThai.Text = "Đơn giá:";
            // 
            // numDonGia
            // 
            numDonGia.BackColor = Color.White;
            numDonGia.BorderStyle = BorderStyle.FixedSingle;
            numDonGia.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numDonGia.ForeColor = Color.FromArgb(220, 38, 38);
            numDonGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numDonGia.Location = new Point(125, 73);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(280, 30);
            numDonGia.TabIndex = 18;
            numDonGia.TextAlign = HorizontalAlignment.Right;
            numDonGia.ThousandsSeparator = true;
            // 
            // label1 (Nhãn Trạng thái - Hàng 2, Cột 2)
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 65, 85);
            label1.Location = new Point(445, 76);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 20;
            label1.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.BackColor = Color.White;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.FlatStyle = FlatStyle.Standard;
            cboTrangThai.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTrangThai.ForeColor = Color.FromArgb(15, 23, 42);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(555, 72);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(260, 31);
            cboTrangThai.TabIndex = 19;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(16, 185, 129);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(24, 124);
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
            btnSua.Location = new Point(168, 124);
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
            btnXoa.Location = new Point(312, 124);
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
            btnLamMoi.Location = new Point(456, 124);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(130, 38);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "🔄 Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvMonAn
            // 
            dgvMonAn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMonAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonAn.BackgroundColor = Color.White;
            dgvMonAn.BorderStyle = BorderStyle.FixedSingle;
            dgvMonAn.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMonAn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            columnHeaderStyle.BackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Padding = new Padding(6);
            columnHeaderStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            columnHeaderStyle.SelectionForeColor = Color.White;
            dgvMonAn.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvMonAn.ColumnHeadersHeight = 42;
            dgvMonAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            defaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            defaultCellStyle.Padding = new Padding(6, 2, 6, 2);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 138);
            dgvMonAn.DefaultCellStyle = defaultCellStyle;

            alternatingRowStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvMonAn.AlternatingRowsDefaultCellStyle = alternatingRowStyle;

            dgvMonAn.EnableHeadersVisualStyles = false;
            dgvMonAn.GridColor = Color.FromArgb(226, 232, 240);
            dgvMonAn.Location = new Point(24, 180);
            dgvMonAn.MultiSelect = false;
            dgvMonAn.Name = "dgvMonAn";
            dgvMonAn.ReadOnly = true;
            dgvMonAn.RowHeadersVisible = false;
            dgvMonAn.RowHeadersWidth = 51;
            dgvMonAn.RowTemplate.Height = 36;
            dgvMonAn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonAn.Size = new Size(791, 336);
            dgvMonAn.TabIndex = 16;
            dgvMonAn.CellClick += dgvMonAn_CellClick;
            // 
            // FrmMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(840, 540);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cboTrangThai);
            Controls.Add(numDonGia);
            Controls.Add(lblTrangThai);
            Controls.Add(dgvMonAn);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboDanhMuc);
            Controls.Add(txtTenMon);
            Controls.Add(lblTenDM);
            MinimumSize = new Size(800, 480);
            Name = "FrmMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thực đơn món ăn";
            ((System.ComponentModel.ISupportInitialize)dgvMonAn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrangThai;
        private DataGridView dgvMonAn;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ComboBox cboDanhMuc;
        private TextBox txtTenMon;
        private Label lblTenDM;
        private NumericUpDown numDonGia;
        private Label label1;
        private ComboBox cboTrangThai;
        private Label label3;
    }
}