using System.Text;

namespace TachDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            List<int> list = new List<int>();
            //Nhập chuỗi kí tự
            Console.WriteLine("Nhập chuỗi kí tự, gõ n để dừng:");
            string kt;
            do
            {
                Console.Write("\t Nhập: ");
                kt = Console.ReadLine();
                if (kt == "n") break;
                list.Add(int.Parse(kt));
            } while (kt.ToLower() != "n");
            //in ra màn hình theo yêu cầu
            foreach (int i in list)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in list)
                if (i % 2 != 0) Console.Write(i + " ");
        }
    }
}