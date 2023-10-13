using System;
namespace testtest1net
{
    public class KhachHangVIP : KhachHang
    {
        private string coupon;
        public string Coupon { get; set; }
        public KhachHangVIP() : base()
        {

        }
        public KhachHangVIP(string maKhachHang, string hoTen, int soLuongMua, double donGia, string coupon) : base(maKhachHang, hoTen, soLuongMua, donGia)
        {
            if (TongTien() < 1000) Coupon = "Coupon 100";
            else if (TongTien() >= 1000 && TongTien() <= 5000) Coupon = "Coupon 200";
            else Coupon = "Coupon 500";
        }
        public override string ToString()
        {
            return string.Format($"{MaKhachHang,-12}{HoTen,30}{SoLuongMua,15}{DonGia,15}{TongTien(),15}{Coupon,15}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            KhachHangVIP khachHangVIP = obj as KhachHangVIP;
            return this.MaKhachHang.Equals(khachHangVIP.MaKhachHang);
        }
    }

}
