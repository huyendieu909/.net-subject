using System.Text;

namespace CanBacHai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Bài 6 này đề bài có vấn đề !? */

            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            csout("Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            csout("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double result = x(a, n);
            Console.WriteLine($"x(n) = (a/x(n-1) + x(n-1)) / 2 = {result}");
        }
        static void csout(object s)
        {
            Console.Write(s);
        }
        static double x(int a, int n)
        {
            if (n == 0) return 1;
            return (a/x(a,n-1)+x(a,n-1))/2;
        }
    }
}