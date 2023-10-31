using System.Text;
using static System.Console;
namespace VD_7_3
{
    internal class Program
    {
        private delegate void HienThiThongBao(string thongBao);
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            OutputEncoding = Encoding.Unicode;
            HienThiThongBao del1 = ThongBaoLoi;
            HienThiThongBao del2 = GuiThongDiep;
            HienThiThongBao multiDel;
            multiDel = del1 + del2;
            HienThiThongBao del3 = CanhBao;
            multiDel += del3;
            multiDel += CanhBao;
            multiDel += CanhBao;
            multiDel -= del2;
            multiDel("ABC");
        }
        static void ThongBaoLoi (string loi)
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Chương trình có lỗi biên dịch: {0}", loi);
            ResetColor();
        }
        static void GuiThongDiep (string ten)
        {
            WriteLine("Thông điệp đã được gửi cho: {0}", ten);
        }
        static void CanhBao (string phienBan)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Bạn nên dùng phiên bản {0}", phienBan);
            ResetColor();
        }
    }
}