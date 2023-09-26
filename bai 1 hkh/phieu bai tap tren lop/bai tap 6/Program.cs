using System.Text;

namespace bai_tap_6
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
                Console.WriteLine("Nhập 1 số nguyên dương: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
            Console.WriteLine("Số vừa nhập: {0}", n);
        }
    }
}