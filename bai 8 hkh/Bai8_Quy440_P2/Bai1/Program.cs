using System.Text;
using static System.Console;
namespace Bai1
{
    internal class Program
    {
        private delegate double Tinh(double a, double b);
        static void Main(string[] args)
        {         
            ForegroundColor = ConsoleColor.Cyan;
            OutputEncoding = Encoding.Unicode;
            string choice = "";
            double a, b;
            do
            {
                Menu();
                Write("Lựa chọn: ");
                choice = ReadLine();
                switch (choice)
                {
                    case "1":
                        Tinh del1 = TinhTong;
                        Nhap(out a, out b);
                        WriteLine($"{a} + {b} = {del1(a, b)}");
                        break;
                    case "2":
                        Tinh del2 = TinhHieu;
                        Nhap(out a, out b);
                        WriteLine($"{a} - {b} = {del2(a, b)}");
                        break;
                    case "3":
                        Tinh del3 = TinhTich;
                        Nhap(out a, out b);
                        WriteLine($"{a} * {b} = {del3(a, b)}");
                        break;
                    case "4":                        
                        Tinh del4 = TinhThuong;
                        Nhap(out a, out b);
                        WriteLine($"{a} . {b} = {del4(a, b)}");
                        break;
                    case "5":
                        WriteLine("Kết thúc chương trình.");
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("--- Vui lòng lựa chọn chính xác yêu cầu ---");
                        break;
                }
            } while (!choice.Equals("5"));            
        }
        static double TinhTong(double x, double y)
        {
            return x + y;
        }
        static double TinhHieu(double x, double y)
        {
            return x - y;
        }
        static double TinhTich(double x, double y)
        {
            return x * y;
        }
        static double TinhThuong(double x, double y)
        {
            return x / y;
        }
        static void Menu()
        {
            WriteLine("=== Lựa chọn phép tính thực hiện ===");
            WriteLine("\t1. Tổng");
            WriteLine("\t2. Hiệu");
            WriteLine("\t3. Tích");
            WriteLine("\t4. Thương");
            WriteLine("\t5. Thoát");
        }
        static void Nhap(out double a, out double b)
        {
            Write("Số thứ nhất: ");
            a = double.Parse(ReadLine());
            Write("Số thứ hai: ");
            b = double.Parse(ReadLine());
        }
    }
}