using System.Text;

namespace btth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Gray;
            int m, n;
            csout("Nhập vào 2 số m, n ứng với phân số m/n\n");
            do {
                csout("Nhập m: ");
                m = int.Parse(Console.ReadLine());
                csout("Nhập n: ");
                n = int.Parse(Console.ReadLine());
                if (n == 0) csout("n phải khác 0!\n");
            } while (n == 0);
            int uclnmn = ucln(m, n);
            m /= uclnmn;
            n /= uclnmn;
            Console.Write($"Phân số rút gọn của m/n là: {m}/{n}\n\n");
        }
        static int ucln(int a, int b)
        {
            if (b == 0) return a;
            return ucln(b, a % b);
        }
        static void csout(object s)
        {
            Console.Write(s);
        }
    }
}