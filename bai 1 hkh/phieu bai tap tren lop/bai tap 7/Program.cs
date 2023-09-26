using System.Text;

namespace bai_tap_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            if (isPrime(n))
            {
                Console.WriteLine($"n = {n} là số nguyên tố");
            } else
            {
                Console.WriteLine($"n = {n} không phải số nguyên tố");
            }
        }
        static bool isPrime(int n)
        {
            if (n == 1) return true;
            if (n == 2) return true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}