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
            btnHuy = new Button();
            btnThem = new Button();
            txtTenTang = new TextBox();
            lblTenTang = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 34;
            label1.Text = "Thêm tầng";
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(164, 199);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 33;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(21, 199);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 32;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenTang
            // 
            txtTenTang.Location = new Point(137, 132);
            txtTenTang.Name = "txtTenTang";
            txtTenTang.Size = new Size(150, 27);
            txtTenTang.TabIndex = 29;
            // 
            // lblTenTang
            // 
            lblTenTang.AutoSize = true;
            lblTenTang.Location = new Point(12, 135);
            lblTenTang.Name = "lblTenTang";
            lblTenTang.Size = new Size(66, 20);
            lblTenTang.TabIndex = 28;
            lblTenTang.Text = "Tên tầng";
            // 
            // FrmThemTang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 325);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(txtTenTang);
            Controls.Add(lblTenTang);
            Name = "FrmThemTang";
            Text = "FrmThemTang";
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