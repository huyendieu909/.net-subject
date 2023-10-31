using System.Text;
using static System.Console;
namespace VD_7_1
{
    internal class Program
    {
        private delegate void HienThiThongBao(string thongBao);
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            HienThiThongBao del1 = ThongBaoLoi;
            del1(" thiếu ; ");
        }
        static void ThongBaoLoi(string loi)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Chương trình của bạn có lỗi biên dịch: {0}", loi);
            ResetColor();
        }
    }
}