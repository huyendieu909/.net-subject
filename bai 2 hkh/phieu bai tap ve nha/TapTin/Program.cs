using System.Text;

namespace TapTin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* đường dẫn sang máy khác có thể khác, cần chỉnh lại sourcePath theo file.text đặt trong project này */
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;
            int sum = 0;
            string sourcePath = "e:\\k5\\lt .net\\bai 2 hkh\\phieu bai tap ve nha\\TapTin\\file.txt";
            using (StreamReader sr = new StreamReader(sourcePath))
            {
                
                string temp;
                try
                {
                    temp = sr.ReadLine();
                    int a = Convert.ToInt32(temp);
                    temp = sr.ReadLine();
                    int b = Convert.ToInt32(temp);
                    int n = a * b;
                    string[] line = new string[n];
                    int i = 0;
                    temp = sr.ReadLine();
                    line = temp.Split(" ");
                    foreach (string s in  line)
                    {
                        sum += int.Parse(s);
                    }
                    Console.WriteLine($"Tổng phần tử của ma trận: {sum}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Không thể mở tập tin {sourcePath}");
                    Console.WriteLine(e.ToString());
                }
            }
            using (StreamWriter sw = new StreamWriter(sourcePath, true))
            {
                sw.WriteLine(sum);
                Console.WriteLine("Đã thực hiện xong!");
            }
        }
    }
}