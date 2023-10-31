using System.Text;
using static System.Console;
namespace VD_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Sử dụng FUNC");
            Func<int, int, int> del1 = Cong2So;
            WriteLine($"{1} + {1} = {del1(1, 1)}");
            WriteLine("Sử dụng ACTION");
            Action<double> del2 = XepLoaiHocSinh;
            del2(9.5);
        }
        static int Cong2So(int x, int y)
        {
            return x + y;
        }
        static void XepLoaiHocSinh(double diemTB)
        {
            Write("Học sinh đạt loại: ");
            if (diemTB >= 8)
            {
                WriteLine("Giỏi");
            }
            else if (diemTB >= 6.5)
            {
                WriteLine("Khá");
            }
            else if (diemTB >= 5)
            {
                WriteLine("Trung bình");
            }
            else if (diemTB >= 3.5)
            {
                WriteLine("Yếu");
            }
            else
            {
                WriteLine("Kém");
            }
        }
    }
}