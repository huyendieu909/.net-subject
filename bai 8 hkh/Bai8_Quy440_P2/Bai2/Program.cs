using System.Text;
using static System.Console;
namespace Bai2
{
    internal class Program
    {
        private delegate void ThemHienDanhSach();
        static List<SinhVien> sv = new List<SinhVien>();
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            ForegroundColor = ConsoleColor.Cyan;
            Write("Nhập số lượng sinh viên: ");
            int n = int.Parse(ReadLine());
            ThemHienDanhSach del1 = ThemSinhVien;
            ThemHienDanhSach del2 = HienThiDanhSach;
            ThemHienDanhSach multiDel = del1;   
            for (int i = 0; i < n-1; i++) { multiDel += del1; };
            multiDel += del2;
            multiDel();
        }
        static void ThemSinhVien()
        {
            Write("Mã sinh viên: ");
            string maSinhVien = ReadLine();
            Write("Họ tên: ");
            string hoTen = ReadLine();
            SinhVien s = new SinhVien(maSinhVien, hoTen);
            sv.Add(s);
        }
        static void HienThiDanhSach()
        {
            WriteLine($"{"Mã sinh viên",-15}{"Họ tên",20}");
            sv.ForEach( s => WriteLine(s));
        }
    }
}