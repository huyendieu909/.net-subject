using System.Text;

namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //tạo List số thực
            List<double> list = new List<double>();
            Console.WriteLine("Nhập 5 số thực: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Nhập số thứ {i+1}: ");
                list.Add(double.Parse(Console.ReadLine()));
            }
            //sắp xếp tăng dần
            list.Sort();
            Console.Write($"Danh sách đã sắp xếp tăng dần: ");
            foreach (double i in list) Console.Write(i + " ");
            //xóa số âm
            foreach (double i in list.ToList())
                if (i < 0) list.Remove(i);
            Console.Write("\nDanh sách đã loại bỏ số âm: ");
            foreach (double i in list) Console.Write(i + " ");
            //chèn x
            /* Ý này chưa hiểu đề bài lắm !? */
            Console.Write($"\nNhập x (0 đến {list.Count()}): ");
            int x = int.Parse(Console.ReadLine());
            list.Insert(x, x);
            Console.Write("Danh sách đã chèn x: ");
            foreach (double c in list) Console.Write(c + " ");
        }
    }
}