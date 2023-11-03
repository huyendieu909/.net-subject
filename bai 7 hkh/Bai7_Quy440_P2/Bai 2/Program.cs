using System.Text;
using static System.Console;
namespace Bai_2
{
    internal class Program
    {
        private delegate void Diem (double x);
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            ForegroundColor = ConsoleColor.Cyan;
            Write("Nhập họ tên sinh viên: ");
            string name = Console.ReadLine();
            Write("Nhập điểm tổng kết: ");
            double diemTK = double.Parse(Console.ReadLine());
            Diem del1 = DiemChu;
            Diem del2 = HocLuc;
            Diem multicDel = del1 + del2;
            WriteLine("Sinh viên: " + name);
            WriteLine("Điểm: " + diemTK);
            multicDel(diemTK);
        }
        static void HocLuc(double diem)
        {
            Write("Học lực: ");
            if (diem >= 8) WriteLine("Giỏi");
            else if (diem >= 6.5) WriteLine("Khá");
            else if (diem >= 5) WriteLine("Trung bình");
            else if (diem >= 3.5) WriteLine("Yếu");
            else WriteLine("Kém");
        }
        static void DiemChu(double diem)
        {
            Write("Điểm chữ: ");
            if (diem < 4) WriteLine("F");
            else if (diem < 5.5) WriteLine("D");
            else if (diem < 7) WriteLine("C");
            else if (diem < 8.5) WriteLine("B");
            else WriteLine("A");
        }
    }
}