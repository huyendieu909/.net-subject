using System.Text;

namespace HeCoSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            /*1. Chuyển N từ hệ 10 sang hệ B*/
            Console.Write("Nhập số N trong hệ 10 cần chuyển đổi: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập hệ cơ số B cần chuyển đến (B phải là 2, 8 hoặc 16): ");
            int b;
            do 
            {
                b = int.Parse(Console.ReadLine());
                if (b != 2 && b != 8 && b != 16)
                {
                    Console.Write("Vui lòng nhập B bằng 2, 8, 10 hoặc 16! Nhập lại: ");
                    
                }
            } while (b != 2 && b != 8 && b != 16);
            Console.WriteLine($"Số {n} trong hệ cơ số {b} là: {Convert.ToString(n, b)}");
            
            /*2. Chuyển N từ hệ B sang hệ 10*/
            Console.Write("Nhập số N trong hệ B cần chuyển đổi: ");
            string n2 = Console.ReadLine();
            Console.Write("N thuộc hệ B = ");
            int b2;
            do
            {
                b2 = int.Parse(Console.ReadLine());
                if (b2 != 2 && b2 != 8 && b2 != 16)
                {
                    Console.Write("Vui lòng nhập B bằng 2, 8 hoặc 16! Nhập lại: ");

                }
            } while (b2 != 2 && b2 != 8 && b2 != 16);
            switch (b2)
            {
                case 2:
                    Console.WriteLine($"Số {n2} từ hệ {b2} chuyển sang hệ 10 bằng: {Convert.ToInt32(n2, 2).ToString()}");
                    break;
                case 8:
                    Console.WriteLine($"Số {n2} từ hệ {b2} chuyển sang hệ 10 bằng: {Convert.ToInt32(n2, 8).ToString()}");
                    break;
                case 16:
                    Console.WriteLine($"Số {n2} từ hệ {b2} chuyển sang hệ 10 bằng: {Convert.ToInt32(n2, 16).ToString()}");
                    break;
            }
        }
    }
}