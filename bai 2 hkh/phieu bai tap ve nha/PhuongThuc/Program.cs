using System.Runtime.Serialization;
using System.Text;

namespace PhuongThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;
            csout("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());
            csout("Nhập phần tử mảng: \n");
            int[] arr = new int[n];
            int[] arrPrime = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\tarr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
                if (isPrime(arr[i])) arrPrime[count++] = arr[i];
            }
            csout("Các số nguyên tố trong mảng là: \n");
            for (int i = 0; i < count; i++) Console.Write($"\t{arrPrime[i]}\n");
        }
        public static bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int  i = 2; i <= Math.Sqrt(n);  i++) {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void csout(object s)
        {
            Console.Write(s);
        }
    }
}