using System.Text;

namespace DanhSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Tạo list ThanhPho
            List<string> ThanhPho = new List<string>();
            //Thêm 5 thành phố trực thuộc trung ương
            ThanhPho.Add("Hà Nội");
            ThanhPho.Add("TP Hồ Chí Minh");
            ThanhPho.Add("Đà Nẵng");
            ThanhPho.Add("Hải Phòng");
            ThanhPho.Add("Cần Thơ");
            //Sắp xếp, in
            Console.WriteLine("Danh sách 5 thành phố trực thuộc trung ương sau khi sắp xếp: ");
            ThanhPho.Sort();
            foreach (string s in ThanhPho) Console.Write($"\t{s}\n");
            //Xóa Hà Nội, thêm 5 thành phố
            ThanhPho.Remove("Hà Nội");
            ThanhPho.Add("Ninh Bình");
            ThanhPho.Add("Đà Lạt");
            ThanhPho.Add("Sầm Sơn");
            ThanhPho.Add("Biên Hòa");
            ThanhPho.Add("Móng Cái");
            Console.WriteLine("Danh sách sau khi xóa \"Hà Nội\" và thêm 5 thành phố khác: ");
            foreach (string s in ThanhPho) Console.Write($"\t{s}\n");
        }
    }
}