using System.Text;

namespace Chuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;

            /*a, hiển thị mỗi kí tự chuỗi trên 1 dòng */
            Console.WriteLine("a,");
            Console.Write("Nhập vào một chuỗi bất kì: ");
            string str = Console.ReadLine();
            Console.WriteLine("a, Hiển thị mỗi kí tự của chuỗi trên 1 dòng: ");
            foreach (char ch in str)
            {
                Console.Write($"\t{ch}\n");
            }

            /*b, tách chuỗi*/
            Console.WriteLine("b, ");
            Console.Write("Nhập chuỗi cần xử lý: ");
            string strb = Console.ReadLine();
            string[] strb_split = strb.Split();
            Console.WriteLine("Kết quả:");
            foreach(string ch in strb_split)
                Console.WriteLine($"\t{ch}");

            /*c, hiển thị số lần kí tự xuất hiện trong chuỗi*/
            Console.WriteLine("c, ");
            Console.Write("Nhập chuỗi cần xử lý: ");
            string strc = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in strc.Replace(" ", ""))
            {
                if (dict.ContainsKey(ch))
                    dict[ch]++;
                else dict.Add(ch, 1);
            }
            Console.WriteLine("Số lần xuất hiện mỗi kí tự trong chuỗi: ");
            foreach (char ch in dict.Keys)
            {
                Console.WriteLine($"\t{ch} : {dict[ch]}");
            }
        }
    }
}