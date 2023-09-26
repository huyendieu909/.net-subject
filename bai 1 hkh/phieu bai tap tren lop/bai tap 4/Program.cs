using System.Text;

namespace bai_tap_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            csout("Nhập bậc lương: ");
            double bacLuong = double.Parse(Console.ReadLine());
            csout("Nhập ngày công: ");
            double ngayCong = double.Parse(Console.ReadLine());
            csout("Nhập phụ cấp: ");
            double phuCap = double.Parse(Console.ReadLine());
            double NCTL;
            if (ngayCong < 25) {
                NCTL = ngayCong;
            }
            else {
                NCTL = 25 + (ngayCong - 25) * 2;
            }
            double tienLinh = bacLuong * 1490000 * NCTL + phuCap;
            Console.WriteLine($"Tiền thực lĩnh: {tienLinh}");
        }
        static void csout(object s)
        {
            Console.Write(s);
        }
    }
}