using System.Text;
using static System.Console;
namespace baitap3
{
    internal class Program
    {
        class TimUSCLN
        {
            private int sothu1;
            private int sothu2;
            public int Sothu1 { get { return sothu1; } set { sothu1 = value; } }
            public int Sothu2 { get {  return sothu2; } set {  sothu2 = value; } }
            public TimUSCLN() { }
            private int UCLN(int a, int b)
            {
                if (b == 0) return a;
                return UCLN(b, a % b);
            }
            public void Input()
            {
                Write("số thứ nhất: ");
                sothu1 = int.Parse(ReadLine());
                Write("số thứ hai: ");
                sothu2 = int.Parse(ReadLine());
            }
            public void KetQua()
            {
                WriteLine($"\tSố thứ nhất: {sothu1}");
                WriteLine($"\tSố thứ hai: {sothu2}");
                WriteLine($"\tUCLN 2 số: {UCLN(sothu1, sothu2)}");
            }
        }
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.Cyan;
            Write("Nhập số lượng đối tượng TimUSCLN cần khởi tạo: ");
            int n = Convert.ToInt32(ReadLine());
            TimUSCLN[] timUSCLN = new TimUSCLN[n];
            WriteLine("=====Nhập thông tin cho các đối tượng=====");
            for (int i = 0; i < n; i++)
            {
                timUSCLN[i] = new TimUSCLN();
                WriteLine("__Nhập thông tin cho đối tượng {0}__", i + 1);
                timUSCLN[i].Input();
            }
            WriteLine("=====Các đối tượng và UCLN tìm được=====");
            for (int i = 0;i < n; i++)
            {
                WriteLine("__Đối tượng {0}__", i + 1);
                timUSCLN[i].KetQua();
            }
        }
    }
}