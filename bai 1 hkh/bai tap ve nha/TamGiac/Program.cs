using System.Text;

namespace TamGiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Gray;
            double a, b, c;
            csout("Nhập 3 cạnh của tam giác\n");
            do
            {
                csout("Nhập cạnh thứ nhất: ");
                a = double.Parse(Console.ReadLine());
                csout("Nhập cạnh thứ hai: ");
                b = double.Parse(Console.ReadLine());
                csout("Nhập cạnh thứ ba: ");
                c = double.Parse(Console.ReadLine());
                if (!isTriangle(a, b, c)) csout("Không phải tam giác! Vui lòng kiểm tra lại độ dài các cạnh\n");
            } while (!isTriangle(a, b, c));
            double cv = a + b + c; // chu vi
            double p = cv / 2; // nửa chu vi
            double s = Math.Sqrt(p * (p-a) * (p-b) * (p-c));
            Console.WriteLine($"Chu vi tam giác đã cho là: {cv}");
            Console.WriteLine($"Diện tích tam giác đã cho là: {s}");
        }
        static bool isTriangle(double a, double b, double c)
        {
            if (a < 0) return false;
            if (b < 0) return false;
            if (c < 0) return false;
            if (a + b <= c) return false;
            if (a + c <= b) return false;
            if (b + c <= a) return false;
            return true;
        }
        static void csout(object s)
        {
            Console.Write(s);
        }
    }
}