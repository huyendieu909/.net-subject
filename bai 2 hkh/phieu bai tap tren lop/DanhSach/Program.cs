using System.Text;

namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nhập n là số số nguyên cần nhập vào danh sách: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập danh sách n số nguyên: \n");
            int[] dsInt = new int[n];
            int[] listEven = new int[n]; // danh sách số chẵn
            int[] listOdd = new int[n]; // danh sách số lẻ
            int[] listPrime = new int[n]; // danh sách số nguyên tố
            int countEven = 0, countOdd = 0, countPrime = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Số thứ {i + 1} = ");
                dsInt[i] = int.Parse(Console.ReadLine());
                if (dsInt[i] % 2 == 0) listEven[countEven++] = dsInt[i];
                else listOdd[countOdd++] = dsInt[i];
                if (isPrime(dsInt[i])) listPrime[countPrime++] = dsInt[i];
            }
            Console.Write("Các số chẵn trong danh sách là: \n");
            for (int i = 0; i < countEven; i++)
            {
                Console.Write($"{listEven[i]}   ");
            }
            Console.WriteLine();
            Console.Write("Các số lẻ trong danh sách là: \n");
            for (int i = 0; i < countOdd; i++)
            {
                Console.Write($"{listOdd[i]}   ");
            }
            Console.WriteLine();
            Console.Write("Các số nguyên tố trong danh sách là: \n");
            for (int i = 0; i < countPrime; i++)
            {
                Console.Write($"{listPrime[i]}   ");
            }
        }
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++) { 
                if (n % i == 0)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
    }
}