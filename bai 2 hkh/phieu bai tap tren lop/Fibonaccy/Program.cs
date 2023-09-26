using System.Text;

namespace Fibonaccy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nhập n: ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine($"{n} số fibonaccy đầu tiên: ");
            //Phương pháp sử dụng đệ quy//
            ulong a;
            for (ulong i = 0; i < n; i++)
            {
                a = f(i); 
                Console.Write($"{a}   ");
            }

            //Phương pháp này ko dùng đệ quy//
            /*if (n == 1) {
                Console.Write("0");
            } else if (n==2){
                Console.Write("0, 1");
            } else
            {
                double f1 = 0;
                double f2 = 1;
                double fn;
                Console.Write("0   1   ");
                for (int i = 2; i < n; i++) {
                    fn = f2 + f1;
                    Console.Write($"{fn}   ");
                    f1 = f2;
                    f2 = fn;  
                }
            }*/
        }
        static ulong f(ulong n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return f(n - 1) + f(n - 2);
        }
    }
}