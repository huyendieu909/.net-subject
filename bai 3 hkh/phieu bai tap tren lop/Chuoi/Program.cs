using System.Text;

namespace Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Nhập chuỗi
            Console.Write("Nhập chuỗi cần kiểm tra tính đối xứng: ");
            string s = Console.ReadLine();
            //tạo chuỗi đảo ngược
            string ss = Reverse(s);
            //kết luận
            if (s != ss) Console.WriteLine("Chuỗi không đối xứng!");
            else Console.WriteLine("Chuỗi đối xứng!");
        }
        static string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}