using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab03_01
{
    public partial class Form1 : Form
    {
        // ===== DỮ LIỆU =====
        private List<SinhVien> dsSinhVien = new List<SinhVien>();
        private BindingSource bs = new BindingSource();
        private SinhVien? svDangChon = null;   // sinh viên đang được chọn để sửa/xóa

        public Form1()
        {
            InitializeComponent();
            ThietKeGiaoDien();
            GanSuKien();
            HienThiDanhSach();
        }

        // =========================================================
        // 1. THIẾT KẾ GIAO DIỆN
        // =========================================================
        private void ThietKeGiaoDien()
        {
            // (Vị trí control, màu 4 nút, Anchor... đã đặt trong Form1.Designer.cs)
            this.MinimumSize = this.Size;   // không cho thu nhỏ hơn kích thước thiết kế

            // ComboBox Khoa
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.Items.Clear();
            cboKhoa.Items.AddRange(new object[] {
                "Công nghệ thông tin", "Quản trị kinh doanh",
                "Kỹ thuật Công trình", "Ngôn ngữ Anh", "Dược" });
            cboKhoa.SelectedIndex = 0;

            // DateTimePicker
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);

            radNam.Checked = true;

            // DataGridView
            DataGridView dgv = dgvSinhVien;
            dgv.RowHeadersVisible = false;   // ẩn cột STT mặc định
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.FixedSingle;
            dgv.GridColor = Color.FromArgb(225, 225, 225);        // đường kẻ ô xám nhạt
            dgv.AllowUserToResizeRows = false;
            dgv.RowTemplate.Height = 24;

            // --- Header: nền xanh, chữ trắng đậm ---
            dgv.EnableHeadersVisualStyles = false;               // BẮT BUỘC, không thì màu header không ăn
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 30;

            // --- Ô dữ liệu ---
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 228, 247); // xanh nhạt khi chọn
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;                    // chữ vẫn đen
            dgv.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 248, 248); // dòng xen kẽ

            // Cột theo đúng thứ tự đề bài, tiêu đề tiếng Việt
            // Số cuối = FillWeight: cột nào số lớn thì rộng hơn
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            ThemCot("MaSV", "Mã SV", 60);
            ThemCot("HoTen", "Họ và Tên", 120);
            ThemCot("NgaySinh", "Ngày sinh", 65).DefaultCellStyle.Format = "dd/MM/yyyy";
            ThemCot("GioiTinh", "Giới tính", 55);
            ThemCot("Khoa", "Khoa", 100);
            ThemCot("DiemTB", "Điểm TB", 110).DefaultCellStyle.NullValue = "Chưa có"; // yêu cầu 6

            dgv.DataSource = bs;
        }

        private DataGridViewTextBoxColumn ThemCot(string thuocTinh, string tieuDe, float doRong)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = thuocTinh;   // phải trùng tên property trong SinhVien
            col.HeaderText = tieuDe;
            col.Name = "col" + thuocTinh;
            col.FillWeight = doRong;            // tỉ lệ độ rộng cột
            dgvSinhVien.Columns.Add(col);
            return col;
        }

        // Gắn sự kiện bằng code -> KHÔNG cần double-click nút trong Designer
        private void GanSuKien()
        {
            btnThem.Click += BtnThem_Click;
            btnCapNhat.Click += BtnCapNhat_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvSinhVien.CellClick += DgvSinhVien_CellClick;
            txtTimKiem.TextChanged += TxtTimKiem_TextChanged;
            // Bỏ tô xanh dòng đầu tiên mà DataGridView tự chọn khi nạp dữ liệu
            dgvSinhVien.DataBindingComplete += (s, e) => dgvSinhVien.ClearSelection();
        }



        // =========================================================
        // 2. HIỂN THỊ + TÌM KIẾM + THỐNG KÊ
        // =========================================================
        private void HienThiDanhSach()
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            List<SinhVien> ketQua = dsSinhVien
                .Where(sv => tuKhoa == ""
                          || ChuaTuKhoa(sv.MaSV, tuKhoa)
                          || ChuaTuKhoa(sv.HoTen, tuKhoa)
                          || ChuaTuKhoa(sv.Khoa, tuKhoa))
                .ToList();

            bs.DataSource = ketQua;
            bs.ResetBindings(false);
            dgvSinhVien.ClearSelection();

            lblTongSo.Text = "Tổng số sinh viên: " + dsSinhVien.Count;

            // Thống kê theo Khoa (LINQ GroupBy)
            var thongKe = dsSinhVien
                .GroupBy(sv => sv.Khoa)
                .Select(g => g.Key + ": " + g.Count());
            lblThongKe.Text = "Theo khoa: " + string.Join("  |  ", thongKe);
        }

        // So sánh không phân biệt hoa/thường
        private bool ChuaTuKhoa(string? chuoi, string tuKhoa)
        {
            return chuoi != null &&
                   chuoi.IndexOf(tuKhoa, StringComparison.CurrentCultureIgnoreCase) >= 0;
        }

        private void TxtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        // =========================================================
        // 3. ĐỌC + KIỂM TRA DỮ LIỆU NHẬP
        // =========================================================
        // Trả về true nếu hợp lệ; diem = null nếu để trống
        private bool KiemTraNhapLieu(out double? diem)
        {
            diem = null;

            if (txtMaSV.Text.Trim() == "")
            {
                BaoLoi("Mã SV không được để trống!", txtMaSV);
                return false;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                BaoLoi("Họ tên không được để trống!", txtHoTen);
                return false;
            }
            if (cboKhoa.SelectedIndex < 0)
            {
                BaoLoi("Vui lòng chọn Khoa!", cboKhoa);
                return false;
            }

            string chuoiDiem = txtDiemTB.Text.Trim();
            if (chuoiDiem != "")
            {
                double d;
                bool laSo = double.TryParse(chuoiDiem.Replace(',', '.'),
                                            NumberStyles.Float,
                                            CultureInfo.InvariantCulture, out d);
                if (!laSo || d < 0 || d > 10)
                {
                    BaoLoi("Điểm TB phải là số từ 0 đến 10!", txtDiemTB);
                    return false;
                }
                diem = d;
            }
            return true;
        }

        private void BaoLoi(string thongBao, Control oLoi)
        {
            MessageBox.Show(thongBao, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            oLoi.Focus();   // đưa con trỏ về đúng ô lỗi
            if (oLoi is TextBox tb) tb.SelectAll();
        }

        private void GhiVaoSinhVien(SinhVien sv, double? diem)
        {
            sv.HoTen = txtHoTen.Text.Trim();
            sv.NgaySinh = dtpNgaySinh.Value.Date;
            sv.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
            sv.Khoa = cboKhoa.SelectedItem?.ToString() ?? "";
            sv.DiemTB = diem;
        }

        // =========================================================
        // 4. THÊM
        // =========================================================
        private void BtnThem_Click(object? sender, EventArgs e)
        {
            if (svDangChon != null)
            {
                MessageBox.Show("Bạn đang ở chế độ sửa. Bấm \"Làm mới\" trước khi thêm sinh viên mới.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double? diem;
            if (!KiemTraNhapLieu(out diem)) return;

            string maSV = txtMaSV.Text.Trim();
            bool trungMa = dsSinhVien.Any(sv =>
                string.Equals(sv.MaSV, maSV, StringComparison.OrdinalIgnoreCase));
            if (trungMa)
            {
                BaoLoi("Mã SV \"" + maSV + "\" đã tồn tại!", txtMaSV);
                return;
            }

            SinhVien moi = new SinhVien { MaSV = maSV };
            GhiVaoSinhVien(moi, diem);
            dsSinhVien.Add(moi);

            HienThiDanhSach();
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
        }

        // =========================================================
        // 5. CHỌN DÒNG -> ĐỔ NGƯỢC LÊN Ô NHẬP
        // =========================================================
        private void DgvSinhVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;   // click vào header thì bỏ qua

            // Lấy đúng object SinhVien của dòng (đúng cả khi đang lọc tìm kiếm)
            SinhVien? sv = dgvSinhVien.Rows[e.RowIndex].DataBoundItem as SinhVien;
            if (sv == null) return;

            svDangChon = sv;
            txtMaSV.Text = sv.MaSV;
            txtMaSV.ReadOnly = true;   // Mã SV là khóa -> không cho sửa
            txtHoTen.Text = sv.HoTen;
            dtpNgaySinh.Value = sv.NgaySinh;
            radNam.Checked = sv.GioiTinh == "Nam";
            radNu.Checked = sv.GioiTinh == "Nữ";
            cboKhoa.SelectedItem = sv.Khoa;
            txtDiemTB.Text = sv.DiemTB.HasValue ? sv.DiemTB.Value.ToString() : "";
        }

        // =========================================================
        // 6. CẬP NHẬT
        // =========================================================
        private void BtnCapNhat_Click(object? sender, EventArgs e)
        {
            if (svDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double? diem;
            if (!KiemTraNhapLieu(out diem)) return;

            GhiVaoSinhVien(svDangChon, diem);
            HienThiDanhSach();
            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LamMoiONhap();
        }

        // =========================================================
        // 7. XÓA
        // =========================================================
        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            if (svDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult xacNhan = MessageBox.Show(
                "Bạn có chắc muốn xóa sinh viên \"" + svDangChon.HoTen + "\" (" + svDangChon.MaSV + ")?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                dsSinhVien.Remove(svDangChon);
                HienThiDanhSach();   // cập nhật luôn lblTongSo
                LamMoiONhap();
            }
        }

        // =========================================================
        // 8. LÀM MỚI
        // =========================================================
        private void BtnLamMoi_Click(object? sender, EventArgs e)
        {
            LamMoiONhap();
        }

        private void LamMoiONhap()
        {
            svDangChon = null;
            txtMaSV.ReadOnly = false;
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            radNam.Checked = true;
            cboKhoa.SelectedIndex = 0;
            dgvSinhVien.ClearSelection();
            txtMaSV.Focus();
        }
    }
}
