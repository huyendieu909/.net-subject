using System.Text;

namespace bai_tap_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nhập vào một số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            //a)
            if (n % 2 == 0) {
                Console.WriteLine($"a) n = {n} là số chẵn");
            }
            else
            {
                Console.WriteLine($"a) n = {n} là số lẻ");
            }
            //b)
            if (n < 0)
            {
                Console.WriteLine($"b) n = {n} là số âm");
            }
            else
            {
                Console.WriteLine($"b) n = {n} là số không âm");
            }
        }
    }
}