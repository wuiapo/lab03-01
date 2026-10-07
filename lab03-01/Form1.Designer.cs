using System.Drawing.Printing;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using Font = System.Drawing.Font;
namespace lab03_01
{
    partial class Form1
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
            grpThongTin = new GroupBox();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            radNam = new RadioButton();
            radNu = new RadioButton();
            lblDiemTB = new Label();
            txtDiemTB = new TextBox();
            lblKhoa = new Label();
            cboKhoa = new ComboBox();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            dgvSinhVien = new DataGridView();
            lblTongSo = new Label();
            lblThongKe = new Label();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.Controls.Add(lblMaSV);
            grpThongTin.Controls.Add(txtMaSV);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(lblGioiTinh);
            grpThongTin.Controls.Add(radNam);
            grpThongTin.Controls.Add(radNu);
            grpThongTin.Controls.Add(lblDiemTB);
            grpThongTin.Controls.Add(txtDiemTB);
            grpThongTin.Controls.Add(lblKhoa);
            grpThongTin.Controls.Add(cboKhoa);
            grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold);
            grpThongTin.Location = new Point(14, 16);
            grpThongTin.Margin = new Padding(3, 4, 3, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 4, 3, 4);
            grpThongTin.Size = new Size(1089, 180);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin sinh viên";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Font = new Font("Segoe UI", 9F);
            lblMaSV.Location = new Point(17, 40);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(54, 20);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV:";
            // 
            // txtMaSV
            // 
            txtMaSV.Font = new Font("Segoe UI", 9F);
            txtMaSV.Location = new Point(109, 35);
            txtMaSV.Margin = new Padding(3, 4, 3, 4);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(182, 27);
            txtMaSV.TabIndex = 0;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F);
            lblHoTen.Location = new Point(326, 40);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(76, 20);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9F);
            txtHoTen.Location = new Point(417, 35);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(274, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F);
            lblNgaySinh.Location = new Point(17, 87);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 9F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(109, 81);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(137, 27);
            dtpNgaySinh.TabIndex = 2;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F);
            lblGioiTinh.Location = new Point(326, 87);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Font = new Font("Segoe UI", 9F);
            radNam.Location = new Point(417, 84);
            radNam.Margin = new Padding(3, 4, 3, 4);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 3;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Font = new Font("Segoe UI", 9F);
            radNu.Location = new Point(491, 84);
            radNu.Margin = new Padding(3, 4, 3, 4);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 4;
            radNu.Text = "Nữ";
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Font = new Font("Segoe UI", 9F);
            lblDiemTB.Location = new Point(577, 87);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(69, 20);
            lblDiemTB.TabIndex = 5;
            lblDiemTB.Text = "Điểm TB:";
            // 
            // txtDiemTB
            // 
            txtDiemTB.Font = new Font("Segoe UI", 9F);
            txtDiemTB.Location = new Point(651, 81);
            txtDiemTB.Margin = new Padding(3, 4, 3, 4);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(91, 27);
            txtDiemTB.TabIndex = 5;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Font = new Font("Segoe UI", 9F);
            lblKhoa.Location = new Point(17, 133);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(46, 20);
            lblKhoa.TabIndex = 6;
            lblKhoa.Text = "Khoa:";
            // 
            // cboKhoa
            // 
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.Font = new Font("Segoe UI", 9F);
            cboKhoa.Location = new Point(109, 128);
            cboKhoa.Margin = new Padding(3, 4, 3, 4);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(274, 28);
            cboKhoa.TabIndex = 6;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(14, 213);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(126, 47);
            btnThem.TabIndex = 1;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(13, 110, 253);
            btnCapNhat.Cursor = Cursors.Hand;
            btnCapNhat.FlatAppearance.BorderSize = 0;
            btnCapNhat.FlatStyle = FlatStyle.Flat;
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(149, 213);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(126, 47);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "✎ Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(283, 213);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(126, 47);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "✕ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(108, 117, 125);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(418, 213);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(126, 47);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "↻ Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimKiem.Location = new Point(14, 283);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(104, 20);
            lblTimKiem.TabIndex = 5;
            lblTimKiem.Text = "🔍 Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(126, 277);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập Mã SV hoặc Họ tên...";
            txtTimKiem.Size = new Size(342, 27);
            txtTimKiem.TabIndex = 5;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.ColumnHeadersHeight = 29;
            dgvSinhVien.Location = new Point(14, 323);
            dgvSinhVien.Margin = new Padding(3, 4, 3, 4);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(1089, 283);
            dgvSinhVien.TabIndex = 6;
            // 
            // lblTongSo
            // 
            lblTongSo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTongSo.AutoSize = true;
            lblTongSo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTongSo.ForeColor = Color.FromArgb(0, 102, 204);
            lblTongSo.Location = new Point(14, 619);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(148, 20);
            lblTongSo.TabIndex = 7;
            // 
            // lblThongKe
            // 
            lblThongKe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblThongKe.AutoSize = true;
            lblThongKe.ForeColor = Color.DimGray;
            lblThongKe.Location = new Point(14, 648);
            lblThongKe.Name = "lblThongKe";
            lblThongKe.Size = new Size(84, 20);
            lblThongKe.TabIndex = 8;
            lblThongKe.Text = "Theo khoa:";
            lblTongSo.Text = "Tổng số sinh viên: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 696);
            Controls.Add(grpThongTin);
            Controls.Add(btnThem);
            Controls.Add(btnCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvSinhVien);
            Controls.Add(lblTongSo);
            Controls.Add(lblThongKe);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpThongTin;
        private Label lblMaSV;
        private TextBox txtMaSV;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private Label lblDiemTB;
        private TextBox txtDiemTB;
        private Label lblKhoa;
        private ComboBox cboKhoa;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private DataGridView dgvSinhVien;
        private Label lblTongSo;
        private Label lblThongKe;
    }
}