using System.Text;

namespace GiaiThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nhập một số nguyên dương để tính giai thừa: ");
            ulong n = ulong.Parse(Console.ReadLine());
            ulong result = giaiThua(n);
            Console.Write($"Giai thừa của {n} là: {result}");
        }
        static ulong giaiThua(ulong n) {
            if (n == 1) return 1;
            return n * giaiThua(--n);
        }
    }
}