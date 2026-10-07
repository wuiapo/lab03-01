namespace lab03_01
{
    partial class FormChinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuQuanLySinhVien = new ToolStripMenuItem();
            mnuQuanLyKhoaHoc = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            mnuCuaSo = new ToolStripMenuItem();
            mnuSapXepTang = new ToolStripMenuItem();
            mnuSapXepNgang = new ToolStripMenuItem();
            mnuSapXepDoc = new ToolStripMenuItem();
            mnuDongTatCa = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuCuaSo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = mnuCuaSo;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLySinhVien, mnuQuanLyKhoaHoc, mnuThoat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(88, 24);
            mnuHeThong.Text = "He Thong";
            // 
            // mnuQuanLySinhVien
            // 
            mnuQuanLySinhVien.Name = "mnuQuanLySinhVien";
            mnuQuanLySinhVien.Size = new Size(224, 26);
            mnuQuanLySinhVien.Text = "Quan Ly Sinh vien";
            mnuQuanLySinhVien.Click += mnuQuanLySinhVien_Click;
            // 
            // mnuQuanLyKhoaHoc
            // 
            mnuQuanLyKhoaHoc.Name = "mnuQuanLyKhoaHoc";
            mnuQuanLyKhoaHoc.Size = new Size(224, 26);
            mnuQuanLyKhoaHoc.Text = "Quan Ly Khoa hoc";
            mnuQuanLyKhoaHoc.Click += mnuQuanLyMonHoc_Click;
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(224, 26);
            mnuThoat.Text = "Thoat";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuCuaSo
            // 
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuSapXepTang, mnuSapXepNgang, mnuSapXepDoc, mnuDongTatCa });
            mnuCuaSo.Name = "mnuCuaSo";
            mnuCuaSo.Size = new Size(69, 24);
            mnuCuaSo.Text = "Cua So";
            // 
            // mnuSapXepTang
            // 
            mnuSapXepTang.Name = "mnuSapXepTang";
            mnuSapXepTang.Size = new Size(224, 26);
            mnuSapXepTang.Text = "Sap Xep Tang";
            mnuSapXepTang.Click += mnuSapXepTang_Click;
            // 
            // mnuSapXepNgang
            // 
            mnuSapXepNgang.Name = "mnuSapXepNgang";
            mnuSapXepNgang.Size = new Size(224, 26);
            mnuSapXepNgang.Text = "Sap Xep Ngang";
            mnuSapXepNgang.Click += mnuSapXepNgang_Click;
            // 
            // mnuSapXepDoc
            // 
            mnuSapXepDoc.Name = "mnuSapXepDoc";
            mnuSapXepDoc.Size = new Size(224, 26);
            mnuSapXepDoc.Text = "Sap Xep Doc";
            mnuSapXepDoc.Click += mnuSapXepDoc_Click;
            // 
            // mnuDongTatCa
            // 
            mnuDongTatCa.Name = "mnuDongTatCa";
            mnuDongTatCa.Size = new Size(224, 26);
            mnuDongTatCa.Text = "Dong Tat Ca";
            mnuDongTatCa.Click += mnuDongTatCa_Click;
            // 
            // FormChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "He thong quan ly";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuQuanLySinhVien;
        private ToolStripMenuItem mnuQuanLyKhoaHoc;
        private ToolStripMenuItem mnuCuaSo;
        private ToolStripMenuItem mnuSapXepTang;
        private ToolStripMenuItem mnuSapXepNgang;
        private ToolStripMenuItem mnuSapXepDoc;
        private ToolStripMenuItem mnuDongTatCa;
        private ToolStripMenuItem mnuThoat;
    }
}
