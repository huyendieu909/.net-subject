using System.Text;

namespace NhapLieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {
                /*
                //a dùng vòng while
                Console.Write("Nhập vào số trong khoảng từ 1 đến 100: ");
                int n = int.Parse(Console.ReadLine());
                while (n < 1 || n > 100)
                {
                    Console.Write("Vui lòng nhập n trong khoảng 1 đến 100! Nhập lại: ");
                    n = Convert.ToInt32(Console.ReadLine());            
                }
                Console.WriteLine($"Số vừa nhập là: {n}");
                */

                //b dùng vòng do
                Console.Write("Nhập vào số trong khoảng từ 1 đến 100: ");
                int n;
                do
                {
                    n = int.Parse(Console.ReadLine());
                    if (n < 0 || n > 100) Console.Write("Vui lòng nhập n trong khoảng 1 đến 100! Nhập lại: ");
                } while (n < 0 || n > 100);
                Console.WriteLine($"Số vừa nhập: {n}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}