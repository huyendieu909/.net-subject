using System.Text;
using static System.Console;
namespace phieubaitap1
{
    internal class Program
    {
        class ThisinhA
        {
            private string sbd;
            private string hoten;
            private string diachi;
            private double toan;
            private double ly;
            private double hoa;
            private double diemUT;
            private double tongdiem;
            public string Sbd { get { return sbd; } set { sbd = value; } }
            public string Hoten { get { return hoten; } set { hoten = value; } }
            public string Diachi { get { return diachi; } set { diachi = value; } }
            public double Toan { get { return toan; } set { toan = value; } }
            public double Ly { get { return ly; } set { ly = value; } }
            public double Hoa { get { return hoa; } set { hoa = value; } }
            public double DiemUT { get { return diemUT; } set { diemUT = value; } }
            public double Tongdiem { get { return tongdiem; } set { tongdiem = toan + ly + hoa + diemUT; } }
            public void Input()
            {
                Write("\tSố báo danh: ");
                sbd = ReadLine();
                Write("\tHọ tên: ");
                hoten = ReadLine();
                Write("\tĐịa chỉ: ");
                diachi = ReadLine();
                Write("\tToán: ");
                toan = double.Parse(ReadLine());
                Write("\tLý: ");
                ly = double.Parse(ReadLine());
                Write("\tHóa: ");
                hoa = double.Parse(ReadLine());
                Write("\tĐiểm ưu tiên: ");
                diemUT = double.Parse(ReadLine());
                tongdiem = toan + ly + hoa + diemUT;
            }
            public void Output()
            {
                WriteLine($"\tSố báo danh: {sbd}");
                WriteLine($"\tHọ tên: {hoten}");
                WriteLine($"\tĐịa chỉ: {diachi}");
                WriteLine($"\tToán: {toan}");
                WriteLine($"\tLý: {ly}");
                WriteLine($"\tHóa: {hoa}");
                WriteLine($"\tĐiểm ưu tiên: {diemUT}");
                WriteLine($"\tTổng điểm: {tongdiem}");
            }
        }
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.Cyan;
            string choice = "";
            List<ThisinhA> list = new List<ThisinhA>();
            do
            {
                menu();
                Write("Nhập lựa chọn: ");
                choice = ReadLine();
                switch (choice)
                {
                    case "1": 
                        ThisinhA thisinhA = new ThisinhA();
                        thisinhA.Input();
                        list.Add(thisinhA);
                        break;
                    case "2":
                        WriteLine("=====Danh sách thí sinh=====");
                        TitleTable();
                        foreach (ThisinhA item in list)
                        {
                            Write("{0,-8}",item.Sbd);
                            Write("{0,-24}", item.Hoten);
                            Write("{0,-24}", item.Diachi);
                            Write("{0,-7}", item.Toan);
                            Write("{0,-5}", item.Ly);
                            Write("{0,-6}", item.Hoa);
                            Write("{0,-16}", item.DiemUT);
                            Write("{0,-9}", item.Tongdiem);
                            WriteLine();
                        }
                        break;
                    case "3":
                        try
                        {
                            Write("Nhập vào 1 số là tổng điểm: ");
                            int td = int.Parse(ReadLine());
                            WriteLine("=====Các thí sinh có tổng điểm >= {0}=====", td);
                            TitleTable();
                            foreach (ThisinhA item in list)
                            {
                                if (item.Tongdiem >= td)
                                {
                                    Write("{0,-8}", item.Sbd);
                                    Write("{0,-24}", item.Hoten);
                                    Write("{0,-24}", item.Diachi);
                                    Write("{0,-7}", item.Toan);
                                    Write("{0,-5}", item.Ly);
                                    Write("{0,-6}", item.Hoa);
                                    Write("{0,-16}", item.DiemUT);
                                    Write("{0,-9}", item.Tongdiem);
                                    WriteLine();
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            WriteLine(e);
                            throw;
                        }
                        break;
                    case "4":
                        try
                        {
                            Write("Nhập 1 địa chỉ: ");
                            string dc = ReadLine();
                            WriteLine("=====Các sinh viên có địa chỉ {0}=====", dc);
                            TitleTable();
                            foreach (ThisinhA item in list)
                            {
                                if (dc.Equals(item.Diachi))
                                {
                                    Write("{0,-8}", item.Sbd);
                                    Write("{0,-24}", item.Hoten);
                                    Write("{0,-24}", item.Diachi);
                                    Write("{0,-7}", item.Toan);
                                    Write("{0,-5}", item.Ly);
                                    Write("{0,-6}", item.Hoa);
                                    Write("{0,-16}", item.DiemUT);
                                    Write("{0,-9}", item.Tongdiem);
                                    WriteLine();
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            WriteLine(e);
                            throw;
                        }
                        break;
                    case "5":
                        Write("Nhập số báo danh để tìm kiếm: ");
                        string sbdt = ReadLine();
                        WriteLine("=====Các sinh viên có địa chỉ {0}=====", sbdt);
                        TitleTable();
                        foreach (ThisinhA item in list)
                        {
                            if (sbdt.Equals(item.Sbd))
                            {
                                Write("{0,-8}", item.Sbd);
                                Write("{0,-24}", item.Hoten);
                                Write("{0,-24}", item.Diachi);
                                Write("{0,-7}", item.Toan);
                                Write("{0,-5}", item.Ly);
                                Write("{0,-6}", item.Hoa);
                                Write("{0,-16}", item.DiemUT);
                                Write("{0,-9}", item.Tongdiem);
                                WriteLine();
                            }
                        }
                        break;
                    case "6":
                        WriteLine("Kết thúc chương trình.");
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("Vui lòng nhập đúng hướng dẫn.");
                        break;
                }
            } while (!choice.Equals("6"));
        }
        static void menu()
        {
            Write("========Menu========\n");
            Write("1. Nhập thông tin 1 thí sinh\n");
            Write("2. Hiển thị danh sách các sinh viên\n");
            Write("3. Hiển thị các sinh viên theo tổng điểm\n");
            Write("4. Hiển thị các sinh viên theo địa chỉ\n");
            Write("5. Tìm kiếm theo số báo danh\n");
            Write("6. Kết thúc chương trình\n");
        }
        //Tiêu đề cho bảng
        static void TitleTable()
        {
            Write("SBD     ");
            Write("Họ tên    \t\t");
            Write("Địa chỉ    \t\t");
            Write("Toán   ");
            Write("Lý   ");
            Write("Hóa   ");
            Write("Điểm ưu tiên   ");
            Write("Tổng điểm\n");
        }
    }
}