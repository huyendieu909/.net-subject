using System.Text;

namespace bai_tap_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Các số từ 1 đến n bỏ qua số chia hết cho 5 là: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0) continue;
                Console.Write(i + " ");
            }
        }
    }
}