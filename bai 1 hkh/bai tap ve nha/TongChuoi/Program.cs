using System.Text;

namespace TongChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            csout("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int a = solve_a(n);
            double b = solve_b(n);
            Console.WriteLine($"a) S = 1 + 2 + 3 + ... + n = {a}");
            Console.WriteLine($"b) S = 1 + 1/2 + 1/3 + ... + 1/n = {b}");
        }
        static void csout(object s)
        {
            Console.Write(s);
        }
        static int solve_a(int n)
        {
            return n*1 + (n*(n-1))/2*1;
        }
        static double solve_b(double n)
        {
            if (n == 1) return 1;
            return 1 / n + (solve_b(--n));
        }
    }
}