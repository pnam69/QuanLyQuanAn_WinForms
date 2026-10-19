using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanAn_WinForms.Forms
{
    partial class FrmThemTang
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
            lblTenTang = new Label();
            txtTenTang = new TextBox();
            btnThem = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // label1 (Tiêu đề Header)
            // 
            label1.AutoSize = false;
            label1.BackColor = Color.FromArgb(30, 41, 59);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 48);
            label1.TabIndex = 34;
            label1.Text = "🏢 THÊM KHU VỰC / TẦNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenTang (Nhãn Tên tầng)
            // 
            lblTenTang.AutoSize = true;
            lblTenTang.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenTang.ForeColor = Color.FromArgb(51, 65, 85);
            lblTenTang.Location = new Point(24, 76);
            lblTenTang.Name = "lblTenTang";
            lblTenTang.Size = new Size(111, 23);
            lblTenTang.TabIndex = 28;
            lblTenTang.Text = "Tên tầng mới:";
            // 
            // txtTenTang (Ô nhập tên tầng)
            // 
            txtTenTang.BackColor = Color.White;
            txtTenTang.BorderStyle = BorderStyle.FixedSingle;
            txtTenTang.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenTang.ForeColor = Color.FromArgb(15, 23, 42);
            txtTenTang.Location = new Point(24, 106);
            txtTenTang.Name = "txtTenTang";
            txtTenTang.Size = new Size(302, 31);
            txtTenTang.TabIndex = 29;
            // 
            // btnThem (Nút Thêm)
            // 
            btnThem.BackColor = Color.FromArgb(16, 185, 129);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(42, 164);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 38);
            btnThem.TabIndex = 32;
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
            btnHuy.Location = new Point(183, 164);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 38);
            btnHuy.TabIndex = 33;
            btnHuy.Text = "✖ Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // FrmThemTang
            // 
            AcceptButton = btnThem;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            CancelButton = btnHuy;
            ClientSize = new Size(350, 230);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(txtTenTang);
            Controls.Add(lblTenTang);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmThemTang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm tầng mới";
            Load += FrmThemTang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHuy;
        private Button btnThem;
        private TextBox txtTenTang;
        private Label lblTenTang;
    }
}