using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmThemBan
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
            label1 = new Label();
            lblSoBan = new Label();
            txtSoBan = new TextBox();
            lblSoGhe = new Label();
            numSoGhe = new NumericUpDown();
            label2 = new Label();
            cboTang = new ComboBox();
            btnThem = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)numSoGhe).BeginInit();
            SuspendLayout();
            // 
            // label1 (Tiêu đề Header)
            // 
            label1.AutoSize = false;
            label1.BackColor = Color.FromArgb(30, 41, 59);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 48);
            label1.TabIndex = 25;
            label1.Text = "➕ THÊM BÀN ĂN MỚI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSoBan (Nhãn Số bàn)
            // 
            lblSoBan.AutoSize = true;
            lblSoBan.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoBan.ForeColor = Color.FromArgb(51, 65, 85);
            lblSoBan.Location = new Point(28, 70);
            lblSoBan.Name = "lblSoBan";
            lblSoBan.Size = new Size(89, 23);
            lblSoBan.TabIndex = 19;
            lblSoBan.Text = "Tên số bàn:";
            // 
            // txtSoBan
            // 
            txtSoBan.BackColor = Color.White;
            txtSoBan.BorderStyle = BorderStyle.FixedSingle;
            txtSoBan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoBan.ForeColor = Color.FromArgb(15, 23, 42);
            txtSoBan.Location = new Point(140, 67);
            txtSoBan.Name = "txtSoBan";
            txtSoBan.Size = new Size(205, 30);
            txtSoBan.TabIndex = 20;
            // 
            // lblSoGhe (Nhãn Số ghế)
            // 
            lblSoGhe.AutoSize = true;
            lblSoGhe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoGhe.ForeColor = Color.FromArgb(51, 65, 85);
            lblSoGhe.Location = new Point(28, 118);
            lblSoGhe.Name = "lblSoGhe";
            lblSoGhe.Size = new Size(67, 23);
            lblSoGhe.TabIndex = 21;
            lblSoGhe.Text = "Số ghế:";
            // 
            // numSoGhe
            // 
            numSoGhe.BackColor = Color.White;
            numSoGhe.BorderStyle = BorderStyle.FixedSingle;
            numSoGhe.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numSoGhe.ForeColor = Color.FromArgb(15, 23, 42);
            numSoGhe.Location = new Point(140, 115);
            numSoGhe.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numSoGhe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoGhe.Name = "numSoGhe";
            numSoGhe.Size = new Size(205, 30);
            numSoGhe.TabIndex = 22;
            numSoGhe.TextAlign = HorizontalAlignment.Center;
            numSoGhe.ThousandsSeparator = true;
            numSoGhe.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label2 (Nhãn Tầng / Khu vực)
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(51, 65, 85);
            label2.Location = new Point(28, 166);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 27;
            label2.Text = "Thuộc tầng:";
            // 
            // cboTang
            // 
            cboTang.BackColor = Color.White;
            cboTang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTang.FlatStyle = FlatStyle.Standard;
            cboTang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTang.ForeColor = Color.FromArgb(15, 23, 42);
            cboTang.FormattingEnabled = true;
            cboTang.Location = new Point(140, 163);
            cboTang.Name = "cboTang";
            cboTang.Size = new Size(205, 31);
            cboTang.TabIndex = 26;
            // 
            // btnThem (Nút Thêm)
            // 
            btnThem.BackColor = Color.FromArgb(16, 185, 129);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(52, 222);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 38);
            btnThem.TabIndex = 23;
            btnThem.Text = "✔ Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy (Nút Hủy)
            // 
            btnHuy.BackColor = Color.FromArgb(100, 116, 139);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(198, 222);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(130, 38);
            btnHuy.TabIndex = 24;
            btnHuy.Text = "✖ Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmThemBan
            // 
            AcceptButton = btnThem;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            CancelButton = btnHuy;
            ClientSize = new Size(380, 285);
            Controls.Add(label2);
            Controls.Add(cboTang);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(numSoGhe);
            Controls.Add(lblSoGhe);
            Controls.Add(txtSoBan);
            Controls.Add(lblSoBan);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmThemBan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm bàn mới";
            ((System.ComponentModel.ISupportInitialize)numSoGhe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numSoGhe;
        private Label lblSoGhe;
        private TextBox txtSoBan;
        private Label lblSoBan;
        private Button btnThem;
        private Button btnHuy;
        private Label label1;
        private ComboBox cboTang;
        private Label label2;
    }
}