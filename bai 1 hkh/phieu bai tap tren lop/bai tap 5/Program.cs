using System.Text;

namespace bai_tap_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            int n;
            do
            {
                Console.Write("Nhập số nguyên nằm trong khoảng 1 đến 7: ");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Chủ nhật");
                        break;
                    case 2:
                        Console.WriteLine("Thứ hai");
                        break;
                    case 3:
                        Console.WriteLine("Thứ ba");
                        break;
                    case 4:
                        Console.WriteLine("Thứ tư");
                        break;
                    case 5:
                        Console.WriteLine("Thứ năm");
                        break;
                    case 6:
                        Console.WriteLine("Thứ sáu");
                        break;
                    case 7:
                        Console.WriteLine("Thứ 7");
                        break;
                }
            } while (n < 1 || n > 7);
        }
    }
}