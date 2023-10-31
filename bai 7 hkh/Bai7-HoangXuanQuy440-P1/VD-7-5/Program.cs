using System.Text;
using static System.Console;
namespace VD_7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("Sử dụng FUNC và PHƯƠNG THỨC VÔ DANH");
            Func<int, int, int> del1 = delegate (int x, int y)
            {
                return x + y;
            };
            WriteLine($"{1} + {2} = {del1(1, 2)}");

            WriteLine("Sử dụng ACTION và BIỂU THỨC LAMBDA");
            Action<double> del2 = diemTB =>
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
            };
            del2(9.5);
        }
    }
}