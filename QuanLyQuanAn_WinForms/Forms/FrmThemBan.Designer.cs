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
            numSoGhe = new NumericUpDown();
            lblSoGhe = new Label();
            txtSoBan = new TextBox();
            lblSoBan = new Label();
            btnThem = new Button();
            btnHuy = new Button();
            label1 = new Label();
            cboTang = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoGhe).BeginInit();
            SuspendLayout();
            // 
            // numSoGhe
            // 
            numSoGhe.Location = new Point(137, 94);
            numSoGhe.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numSoGhe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoGhe.Name = "numSoGhe";
            numSoGhe.Size = new Size(150, 27);
            numSoGhe.TabIndex = 22;
            numSoGhe.ThousandsSeparator = true;
            numSoGhe.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // lblSoGhe
            // 
            lblSoGhe.AutoSize = true;
            lblSoGhe.Location = new Point(12, 96);
            lblSoGhe.Name = "lblSoGhe";
            lblSoGhe.Size = new Size(55, 20);
            lblSoGhe.TabIndex = 21;
            lblSoGhe.Text = "Số ghế";
            // 
            // txtSoBan
            // 
            txtSoBan.Location = new Point(137, 45);
            txtSoBan.Name = "txtSoBan";
            txtSoBan.Size = new Size(150, 27);
            txtSoBan.TabIndex = 20;
            // 
            // lblSoBan
            // 
            lblSoBan.AutoSize = true;
            lblSoBan.Location = new Point(12, 48);
            lblSoBan.Name = "lblSoBan";
            lblSoBan.Size = new Size(55, 20);
            lblSoBan.TabIndex = 19;
            lblSoBan.Text = "Số bàn";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(35, 235);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(178, 235);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 24;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 25;
            label1.Text = "Thêm bàn";
            // 
            // cboTang
            // 
            cboTang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTang.FormattingEnabled = true;
            cboTang.Location = new Point(136, 149);
            cboTang.Name = "cboTang";
            cboTang.Size = new Size(151, 28);
            cboTang.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 27;
            label2.Text = "Tầng";
            // 
            // FrmThemBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 276);
            Controls.Add(label2);
            Controls.Add(cboTang);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(numSoGhe);
            Controls.Add(lblSoGhe);
            Controls.Add(txtSoBan);
            Controls.Add(lblSoBan);
            Name = "FrmThemBan";
            Text = "FrmThemBan";
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