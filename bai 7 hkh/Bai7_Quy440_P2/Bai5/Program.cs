using System.Text;
using static System.Console;
namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            ForegroundColor = ConsoleColor.Cyan;
            Write("Nhập họ tên nhân viên: ");
            string name = ReadLine();
            Write("Nhập số tiền bán hàng: ");
            double soTienBanHang = double.Parse(ReadLine());
            Func<double, double> del1 = (double soTienHoaHong) =>
            {
                double phanTramHoaHong;
                if (soTienBanHang < 1000) phanTramHoaHong = 0;
                else if (soTienBanHang <= 3000) phanTramHoaHong = 0.05;
                else phanTramHoaHong = 0.1;
                return soTienBanHang * phanTramHoaHong;
            };
            Write($"Tiền hoa hồng: {del1(soTienBanHang)}");
        }
    }
}