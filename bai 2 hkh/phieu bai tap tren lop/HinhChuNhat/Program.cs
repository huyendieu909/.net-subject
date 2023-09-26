using System.Text;

namespace HinhChuNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Nhập vào chiều dài của hình chữ nhật: ");
            double chDai = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập vào chiều rộng của hình chữ nhật: ");
            double chRong = int.Parse(Console.ReadLine());
            double chuVi = (chDai + chRong) * 2;
            double dienTich = chDai * chRong;
            Console.WriteLine($"Chu vi của hình chữ nhật đó là: {chuVi}");
            Console.WriteLine($"Diện tích của hình chữ nhật đó là: {dienTich}");
        }
    }
}