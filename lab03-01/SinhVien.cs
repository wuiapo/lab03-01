using System;

namespace lab03_01
{
    public class SinhVien
    {
        public string MaSV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; } = "";
        public string Khoa { get; set; } = "";
        public double? DiemTB { get; set; }   // null = chưa có điểm
    }
}
