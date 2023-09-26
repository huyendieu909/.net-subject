using System.Text;

namespace TamGiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Nhập cạnh
            Console.WriteLine("Nhập vào 3 cạnh của tam giác: ");
            int a, b, c;
            do
            {
                Console.Write("Cạnh thứ nhất: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Cạnh thứ hai: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Cạnh thứ ba: ");
                c = int.Parse(Console.ReadLine());
                if (!isTriangle(a, b, c)) Console.WriteLine("Các cạnh vừa nhập không tạo ra tam giác! Vui lòng nhập lại.");
            } while (!isTriangle(a, b, c));
            //kiểm tra tam giác thì thực hiện tính chu vi diện tích
            int chuvi;
            double dientich;
            if (isTriangle(a,b,c)) {
                cal(a,b,c,out chuvi,out dientich);
                Console.WriteLine($"Chu vi = {chuvi}\nDiện tích = {dientich}");
            }
        }
        static bool isTriangle(int a, int b, int c)
        {
            if (a + b > c && b + c > a && a + c > b) return true;
            else return false;
        }
        static void cal(int a, int b, int c, out int chuvi, out double dientich)
        {
            chuvi = a + b + c;
            int p = chuvi / 2;
            dientich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}