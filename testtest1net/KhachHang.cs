using System;
namespace testtest1net
{
    public class KhachHang
    {
        private string maKhachHang;
        private string hoten;
        private int soLuongMua;
        private double donGia;
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public int SoLuongMua { get; set; }
        public double DonGia { get; set; }
        public KhachHang() { }
        public KhachHang(string maKhachHang, string hoTen, int soLuongMua, double donGia)
        {
            MaKhachHang = maKhachHang;
            HoTen = hoTen;
            SoLuongMua = soLuongMua;
            DonGia = donGia;
        }
        public double TongTien()
        {
            return SoLuongMua * DonGia;
        }

        public override string ToString()
        {
            return string.Format($"{MaKhachHang,-12}{HoTen,30}{SoLuongMua,15}{DonGia,15}{TongTien(),15}");
        }
    }

}
