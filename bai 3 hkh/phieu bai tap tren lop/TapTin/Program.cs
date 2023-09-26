using System.Text;
using System.IO;
namespace TapTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            StreamWriter sw = new StreamWriter("E:\\file.txt");
            StreamReader sr = new StreamReader("E:\\fileread.txt");
            string line;
            int count = 0;
            while ((line = sr.ReadLine()) != null)
            {
                foreach (char c in line)
                    if (c == ' ') count++;
                sw.WriteLine(line.ToUpper());
            }
            sw.WriteLine(++count);
            sw.Close();
            sr.Close();
        }
    }
}