namespace lab03_01
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            this.MdiChildActivate += FormChinh_MdiChildActivate;
            this.FormClosing += FormChinh_FormClosing;
        }
        private void FormChinh_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                var ketQua = MessageBox.Show(
                "Vẫn còn cửa sổ con đang mở. Bạn có chắc muốn thoát ứng dụng?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ketQua == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        private void FormChinh_MdiChildActivate(object? sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.Text = $"Hệ Thống Quản Lý — HUTECH | Đang xem: {this.ActiveMdiChild.Text}";
            }
            else
            {
                this.Text = "Hệ Thống Quản Lý — HUTECH";
            }
        }
        private void MoFormKhongTrung<T>() where T : Form, new()
        {
            foreach (Form formCon in this.MdiChildren)
            {
                if (formCon is T)
                {
                    formCon.Activate();
                    return;
                }
            }
            T formMoi = new T();
            formMoi.MdiParent = this;
            formMoi.Show();
        }

        private void mnuQuanLySinhVien_Click(object sender, EventArgs e)
        {
            MoFormKhongTrung<Form1>();
        }

        private void mnuQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            MoFormKhongTrung<FormQuanLyKhoaHoc>();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===================== Sắp xếp cửa sổ =====================
        private void mnuSapXepTang_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void mnuSapXepNgang_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void mnuSapXepDoc_Click(object sender, EventArgs e)
        {
            if (!KiemTraCoCuaSoDangMo()) return;
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private bool KiemTraCoCuaSoDangMo()
        {
            if (this.MdiChildren.Length == 0)
            {
                MessageBox.Show(
                "Chưa có cửa sổ nào để sắp xếp!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void mnuDongTatCa_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                MessageBox.Show(
                "Không có cửa sổ nào đang mở!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
            }
            var ketQua = MessageBox.Show(
            $"Bạn có chắc muốn đóng tất cả {this.MdiChildren.Length} cửa sổ đang mở?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
            {
                // Duyệt bằng ToList() vì đóng form sẽ làm thay đổi mảng MdiChildren khi đang lặp
                foreach (Form formCon in this.MdiChildren.ToList())
                {
                    formCon.Close();
                }
            }
        }
    }
}
