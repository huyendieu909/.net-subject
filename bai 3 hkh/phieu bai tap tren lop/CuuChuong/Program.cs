using System.Text;

namespace CuuChuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====Bảng cửu chương=====");
            for (int i = 1;  i <= 9; i++) {
                Console.WriteLine($"Bảng {i}");
                for (int j = 1 ; j <= 10 ; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
                Console.WriteLine();
            }
        }
    }
}