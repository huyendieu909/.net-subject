using System.Text;

namespace Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                //Nhập mảng
                Console.Write("Nhập số phần tử mảng: ");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Console.WriteLine("Nhập các phần tử: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Phần tử thứ {i + 1}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                //tính tổng lẻ
                int sumOdd = 0;
                foreach (int i in arr)
                    if (i % 2 != 0) sumOdd += i;
                Console.WriteLine($"Tổng phần tử lẻ trong mảng là: {sumOdd}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}