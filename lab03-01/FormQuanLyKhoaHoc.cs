namespace lab03_01
{
    public partial class FormQuanLyKhoaHoc : Form
    {
        public FormQuanLyKhoaHoc()
        {
            InitializeComponent();
            nudSoTinChi.Minimum = 1;
            nudSoTinChi.Maximum = 10;
            nudSoTinChi.Value = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaKhoaHoc.Text.Trim();
            string ten = txtTenKhoaHoc.Text.Trim();

            if (ma == "")
            {
                BaoLoi("Mã khóa học không được để trống!", txtMaKhoaHoc);
                return;
            }
            if (ten == "")
            {
                BaoLoi("Tên khóa học không được để trống!", txtTenKhoaHoc);
                return;
            }

            bool trungMa = lstKhoaHoc.Items.Cast<KhoaHoc>()
                .Any(kh => string.Equals(kh.MaKhoaHoc, ma, StringComparison.OrdinalIgnoreCase));
            if (trungMa)
            {
                BaoLoi("Mã khóa học \"" + ma + "\" đã tồn tại!", txtMaKhoaHoc);
                return;
            }

            KhoaHoc moi = new KhoaHoc
            {
                MaKhoaHoc = ma,
                TenKhoaHoc = ten,
                SoTinChi = (int)nudSoTinChi.Value
            };
            lstKhoaHoc.Items.Add(moi);

            txtMaKhoaHoc.Clear();
            txtTenKhoaHoc.Clear();
            nudSoTinChi.Value = 3;
            txtMaKhoaHoc.Focus();
        }

        private void BaoLoi(string thongBao, Control oLoi)
        {
            MessageBox.Show(thongBao, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            oLoi.Focus();
            if (oLoi is TextBox tb) tb.SelectAll();
        }
    }
}