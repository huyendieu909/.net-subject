using System.Text;

namespace XepLoaiHS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            csout("Nhập vào tên của học sinh: ");
            String s = Console.ReadLine();
            csout("Nhập điểm thi cuối kì của học sinh đó: ");
            double diem = double.Parse(Console.ReadLine());
            string v = s.ToUpper();
            string xl;
            if (diem >= 8) xl = "Giỏi";
            else if (diem >= 6.5) xl = "Khá";
            else if (diem >= 5) xl = "Trung bình";
            else xl = "Yếu";
            Console.WriteLine($"Tên in hoa: \t{v} \n  Xếp loại:\t {xl}");
        }
        static void csout(object s)
        {
            Console.Write(s);
        }
    }
}