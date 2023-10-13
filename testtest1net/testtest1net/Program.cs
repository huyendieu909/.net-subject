using System.Text;
using static System.Console;
namespace testtest1net
{
    internal class Program
    {
        static List<KhachHang> list = new List<KhachHang>();
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.Cyan;
            string choice = "";
            do
            {
                Menu();
                Write("Nhập lựa chọn của bạn: ");
                choice = ReadLine();
                switch (choice)
                {
                    case "1":
                        string choice1 = "";
                        do
                        {
                            Menu1();
                            Write("Nhập lựa chọn: ");
                            choice1 = ReadLine();
                            switch (choice1)
                            {
                                case "1":
                                    Write("Mã khách hàng: ");
                                    string maKhachHang = ReadLine();
                                    int count = 0;
                                    foreach (KhachHang i in list)
                                    {
                                        if (maKhachHang.Equals(i.MaKhachHang)) count++;
                                    }
                                    if (count != 0)
                                    {
                                        WriteLine(maKhachHang + " đã tồn tại trong danh sách !");
                                    }
                                    else
                                    {
                                        Write("Họ tên khách hàng: ");
                                        string hoTen = ReadLine();
                                        Write("Số lượng mua: ");
                                        int soLuongMua = int.Parse(ReadLine());
                                        Write("Đơn giá: ");
                                        double donGia = double.Parse(ReadLine());
                                        KhachHang a = new KhachHang(maKhachHang, hoTen, soLuongMua, donGia);
                                        list.Add(a);
                                    }
                                    break;
                                case "2":
                                    Write("Mã khách hàng: ");
                                    string maKhachHang2 = ReadLine();
                                    int count2 = 0;
                                    foreach (KhachHang i in list)
                                    {
                                        if (maKhachHang2.Equals(i.MaKhachHang)) count2++;
                                    }
                                    if (count2 != 0) WriteLine(maKhachHang2 + " đã tồn tại trong danh sách !");
                                    else
                                    {
                                        Write("Họ tên khách hàng: ");
                                        string hoTen2 = ReadLine();
                                        Write("Số lượng mua: ");
                                        int soLuongMua2 = int.Parse(ReadLine());
                                        Write("Đơn giá: ");
                                        double donGia2 = double.Parse(ReadLine());
                                        KhachHangVIP b = new KhachHangVIP(maKhachHang2, hoTen2, soLuongMua2, donGia2, "");
                                        list.Add(b);
                                    }
                                    break;
                            }
                        } while (!choice1.Equals("1") && !choice1.Equals("2"));
                        break;
                    case "2":
                        WriteLine("====Danh sách khách hàng====");
                        WriteLine($"{"Mã khách hàng",-12}{"Họ tên",30}{"Số lượng mua",15}{"Đơn giá",15}{"Tổng tiền",15}{"Quà tặng", 15}");
                        foreach (KhachHang i in list)
                        {
                            WriteLine(i.ToString());
                        }
                        break;
                    case "3":
                        int maxC = list[0].SoLuongMua;
                        foreach (KhachHang i in list)
                        {
                            if (maxC < i.SoLuongMua)
                            {
                                maxC = i.SoLuongMua;
                            }
                        }
                        WriteLine("====Danh sách khách hàng có lượng mua lớn nhất====");
                        WriteLine($"{"Mã khách hàng",-12}{"Họ tên",30}{"Số lượng mua",15}{"Đơn giá",15}{"Tổng tiền",15}{"Quà tặng",15}");
                        foreach (KhachHang i in list)
                        {
                            if (i.SoLuongMua == maxC)
                            {
                                WriteLine(i.ToString());
                            }
                        }
                        break;
                    case "4":
                        WriteLine("Kết thúc chương trình.");
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("\n_____Vui lòng nhập đúng lựa chọn!_____\n");
                        break;
                }
            } while (!choice.Equals("4"));
        }
        static void Menu()
        {
            WriteLine("========== Main menu ==========");
            WriteLine("\t1. Nhập thông tin ");
            WriteLine("\t2. Hiển thị danh sách");
            WriteLine("\t3. Tìm khách hàng");
            WriteLine("\t4. Thoát");
        }
        static void Menu1()
        {
            WriteLine("---Chọn loại khách hàng---");
            WriteLine("\t1. Khách hàng");
            WriteLine("\t2. Khách hàng VIP");
        }
    }
}