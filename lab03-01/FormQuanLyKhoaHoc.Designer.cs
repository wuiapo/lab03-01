namespace lab03_01
{
    partial class FormQuanLyKhoaHoc
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
            lblMaKhoaHoc = new Label();
            lblTenKhoaHoc = new Label();
            lblSoTinChi = new Label();
            lblDanhSachKhoaHoc = new Label();
            txtMaKhoaHoc = new TextBox();
            txtTenKhoaHoc = new TextBox();
            lstKhoaHoc = new ListBox();
            nudSoTinChi = new NumericUpDown();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSoTinChi).BeginInit();
            SuspendLayout();
            // 
            // lblMaKhoaHoc
            // 
            lblMaKhoaHoc.AutoSize = true;
            lblMaKhoaHoc.Location = new Point(37, 51);
            lblMaKhoaHoc.Name = "lblMaKhoaHoc";
            lblMaKhoaHoc.Size = new Size(99, 20);
            lblMaKhoaHoc.TabIndex = 0;
            lblMaKhoaHoc.Text = "Ma Khoa Hoc";
            // 
            // lblTenKhoaHoc
            // 
            lblTenKhoaHoc.AutoSize = true;
            lblTenKhoaHoc.Location = new Point(37, 104);
            lblTenKhoaHoc.Name = "lblTenKhoaHoc";
            lblTenKhoaHoc.Size = new Size(101, 20);
            lblTenKhoaHoc.TabIndex = 1;
            lblTenKhoaHoc.Text = "Ten Khoa Hoc";
            // 
            // lblSoTinChi
            // 
            lblSoTinChi.AutoSize = true;
            lblSoTinChi.Location = new Point(37, 155);
            lblSoTinChi.Name = "lblSoTinChi";
            lblSoTinChi.Size = new Size(75, 20);
            lblSoTinChi.TabIndex = 2;
            lblSoTinChi.Text = "So Tin Chi";
            // 
            // lblDanhSachKhoaHoc
            // 
            lblDanhSachKhoaHoc.AutoSize = true;
            lblDanhSachKhoaHoc.Location = new Point(37, 221);
            lblDanhSachKhoaHoc.Name = "lblDanhSachKhoaHoc";
            lblDanhSachKhoaHoc.Size = new Size(148, 20);
            lblDanhSachKhoaHoc.TabIndex = 3;
            lblDanhSachKhoaHoc.Text = "Danh Sach Khoa Hoc";
            // 
            // txtMaKhoaHoc
            // 
            txtMaKhoaHoc.Location = new Point(168, 51);
            txtMaKhoaHoc.Name = "txtMaKhoaHoc";
            txtMaKhoaHoc.Size = new Size(234, 27);
            txtMaKhoaHoc.TabIndex = 4;
            // 
            // txtTenKhoaHoc
            // 
            txtTenKhoaHoc.Location = new Point(168, 104);
            txtTenKhoaHoc.Name = "txtTenKhoaHoc";
            txtTenKhoaHoc.Size = new Size(290, 27);
            txtTenKhoaHoc.TabIndex = 5;
            // 
            // lstKhoaHoc
            // 
            lstKhoaHoc.FormattingEnabled = true;
            lstKhoaHoc.Location = new Point(37, 265);
            lstKhoaHoc.Name = "lstKhoaHoc";
            lstKhoaHoc.Size = new Size(452, 284);
            lstKhoaHoc.TabIndex = 7;
            // 
            // nudSoTinChi
            // 
            nudSoTinChi.Location = new Point(168, 155);
            nudSoTinChi.Name = "nudSoTinChi";
            nudSoTinChi.Size = new Size(95, 27);
            nudSoTinChi.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(330, 146);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(104, 51);
            btnThem.TabIndex = 9;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // FormQuanLyKhoaHoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 579);
            Controls.Add(btnThem);
            Controls.Add(nudSoTinChi);
            Controls.Add(lstKhoaHoc);
            Controls.Add(txtTenKhoaHoc);
            Controls.Add(txtMaKhoaHoc);
            Controls.Add(lblDanhSachKhoaHoc);
            Controls.Add(lblSoTinChi);
            Controls.Add(lblTenKhoaHoc);
            Controls.Add(lblMaKhoaHoc);
            Name = "FormQuanLyKhoaHoc";
            Text = "Quan Ly Khoa Hoc";
            ((System.ComponentModel.ISupportInitialize)nudSoTinChi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaKhoaHoc;
        private Label lblTenKhoaHoc;
        private Label lblSoTinChi;
        private Label lblDanhSachKhoaHoc;
        private TextBox txtMaKhoaHoc;
        private TextBox txtTenKhoaHoc;
        private ListBox lstKhoaHoc;
        private NumericUpDown nudSoTinChi;
        private Button btnThem;
    }
}