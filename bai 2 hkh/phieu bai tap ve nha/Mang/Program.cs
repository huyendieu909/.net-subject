using System.Text;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nhập vào kích thước của mảng: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị các phần tử mảng: \n");
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Phần tử lớn nhất trong mảng là: {arr.Max()}");
            Console.WriteLine($"Phần tử nhỏ nhất trong mảng là: {arr.Min()}");
            Console.WriteLine($"Tổng các phần tử trong mảng là: {arr.Sum()}");
        }
    }
}