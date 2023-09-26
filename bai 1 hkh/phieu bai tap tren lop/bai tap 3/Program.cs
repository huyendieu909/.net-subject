using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace bai_tap_3
{
    internal class Program
    {
        static int a, b, c;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            int choice;
            do
            {
                menu();
                csout("Nhập lựa chọn: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    solve_a(a, b);
                }
                if (choice == 2)
                {
                    solve_b(a, b, c);
                }
            } while (choice != 0);
            
            

        }
        static void solve_a(int a, int b)
        {
            Console.Write("Nhập a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            b = int.Parse(Console.ReadLine());
            calculate_a(a, b);
        }
        
        static void solve_b(int a, int b, int c) {
            Console.Write("Nhập a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhập c: ");
            c = int.Parse(Console.ReadLine());
            if (a  == 0) {
                calculate_a(b, c);   
            }
            double delta = b*b - 4*a*c;
            if (delta < 0)
            {
                csout("Phương trình vô nghiệm\n");
            }
            else if (delta == 0) {
                double x = (double)-b / (2*a);
                Console.WriteLine("Phương trình có nghiệm duy nhất x = {0}\n", x);    
            }
            else
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phương trình có 2 nghiệm: x1 = {0},\t x2 = {1}\n", x1, x2);
            }
        }
        static double calculate_a(int a, int b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    csout("Phương trình vô số nghiệm\n\n");
                    return 0;
                }
                else
                {
                    csout("Phương trình vô nghiệm\n\n");
                    return 0;
                }
            }
            else
            {
                double x = (double)-b / a;
                Console.WriteLine("Phương trình có nghiệm x = {0}\n", x);
                return x;
            }
        }
        static void csout(object s)
        {
            Console.Write(s);
        }
        
        static void menu()
        {
            csout("\tMenu\n");
            csout("1. Giải phương trình ax + b = 0\n");
            csout("2. Giải phương trình ax2 + bx + c = 0\n");
            csout("0. Kết thúc chương trình.\n");
        }
    }
}