using System.Runtime.InteropServices;
using System.Text;

namespace CauTruc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;
            HocSinh[] hs = new HocSinh[5];
            int tongTuoi = 0;
            Console.WriteLine("Nhập thông tin cho 5 học sinh: ");
            for (int i = 0; i < hs.Length; i++) {
                hs[i] = new HocSinh();
                Console.Write($"Nhập họ tên học sinh thứ {i+1}: ");
                hs[i].hoTen = Console.ReadLine();
                Console.Write($"Nhập tuổi học sinh thứ {i + 1}: ");
                hs[i].tuoi = int.Parse(Console.ReadLine());
                Console.Write("Giới tính (nam 1 nữ 0): ");
                int gend = int.Parse(Console.ReadLine());
                if (gend == 0) hs[i].gioiTinh = false;
                else hs[i].gioiTinh = true;
                tongTuoi += hs[i].tuoi;
                Console.WriteLine();
            }
            Console.WriteLine($"Tổng số tuổi 5 học sinh trong mảng là: {tongTuoi}");
        }
        struct HocSinh
        {
            public string hoTen;
            public int tuoi;
            public bool gioiTinh;
        }
    }
}