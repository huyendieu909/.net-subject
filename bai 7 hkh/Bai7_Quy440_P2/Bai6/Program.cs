using System.Text;
using static System.Console;
namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            ForegroundColor = ConsoleColor.Cyan;
            Write("Nhập tên người lao động: ");
            string name = ReadLine();
            Write("Nhập thu nhập: ");
            double income = double.Parse(ReadLine());
            Action<string, double> del1 = (string name, double income) =>
            {
                double tax;
                if (income <= 5000000) tax = income * 0.05;
                else if (income <= 10000000) tax = income * 0.1 - 250000;
                else tax = income * 0.2 - 750000;
                WriteLine("Thuế thu nhập: {0}", tax);
            };
            del1(name, income);
        }
    }
}