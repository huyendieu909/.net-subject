using System.Text;

namespace TinhToan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //nhập a b p
            csout("Nhập giá trị a: a = ");
            double a = double.Parse(Console.ReadLine());
            csout("Nhập giá trị b: b = ");
            double b = double.Parse(Console.ReadLine());
            csout("Nhập p: ");
            string pt = Console.ReadLine();
            switch (pt)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        static void csout(object o)
        {
            Console.Write(o);
        }
    }
}