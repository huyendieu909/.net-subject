using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using static System.Console;
using System.Collections;

namespace phieubaitap2
{
    internal class Program
    {
        static List<Vehicles> list = new List<Vehicles>();
        class SortByYear : IComparer<Vehicles>
        {
            public int Compare(Vehicles? x, Vehicles? y)
            {
                return x.Year.CompareTo(y.Year);
            }
        }
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.Cyan;
            string choice = "";
            do
            {
                menu();
                Write("Nhập lựa chọn của bạn: ");
                choice = ReadLine();
                switch (choice)
                {
                    case "1":
                        string addChoice = "";
                        do
                        {
                            menuAdd();
                            Write("Lựa chọn: ");
                            addChoice = ReadLine();
                            switch (addChoice)
                            {
                                case "1":
                                    Car car = new Car();
                                    car.Input();
                                    list.Add(car);
                                    break;
                                case "2":
                                    Truck truck = new Truck();
                                    truck.Input();
                                    list.Add(truck);
                                    break;
                                default:
                                    WriteLine("_Vui lòng lựa chọn chính xác!_");
                                    break;
                            }
                        } while (!addChoice.Equals("1") && !addChoice.Equals("2"));
                        break;
                    case "2":
                        WriteLine("\n\t----- Danh sách xe đã nhập -----");
                        WriteLine("{0, -6}{1, 15}{2, 15}{3, 8}{4, 10}{5, 10}{6, 10}", "Id", "Maker", "Model", "Year", "Price", "Color", "Truckload");
                        foreach (Vehicles obj in list)
                        {
                            obj.Output();
                            WriteLine();
                        }
                        break;
                    case "3":
                        Write("---Nhập id xe cần tìm: ");
                        string idSearch = ReadLine();
                        WriteLine("\n\t----- Xe có id {0} trong danh sách -----", idSearch);
                        WriteLine("{0, -6}{1, 15}{2, 15}{3, 8}{4, 10}{5, 10}{6, 10}", "Id", "Maker", "Model", "Year", "Price", "Color", "Truckload");
                        foreach (Vehicles obj in list)
                        {
                            if (obj.Id.Equals(idSearch))
                            {
                                obj.Output();
                                WriteLine();
                            }
                        }
                        break;
                    case "4":
                        Write("---Nhập maker xe cần tìm: ");
                        string makerSearch = ReadLine();
                        WriteLine("\n\t----- Xe có maker {0} trong danh sách -----", makerSearch);
                        WriteLine("{0, -6}{1, 15}{2, 15}{3, 8}{4, 10}{5, 10}{6, 10}", "Id", "Maker", "Model", "Year", "Price", "Color", "Truckload");
                        foreach (Vehicles obj in list)
                        {
                            if (obj.Maker.Equals(makerSearch))
                            {
                                obj.Output();
                                WriteLine();
                            }
                        }
                        break;
                    case "5":
                        list.Sort();
                        WriteLine("\n\t----- Danh sách xe đã sắp xếp theo price -----");
                        WriteLine("{0, -6}{1, 15}{2, 15}{3, 8}{4, 10}{5, 10}{6, 10}", "Id", "Maker", "Model", "Year", "Price", "Color", "Truckload");
                        foreach (Vehicles obj in list)
                        {
                            obj.Output();
                            WriteLine();
                        }
                        break;
                    case "6":
                        list.Sort(new SortByYear());
                        WriteLine("\n\t----- Danh sách xe đã sắp xếp theo year -----");
                        WriteLine("{0, -6}{1, 15}{2, 15}{3, 8}{4, 10}{5, 10}{6, 10}", "Id", "Maker", "Model", "Year", "Price", "Color", "Truckload");
                        foreach (Vehicles obj in list)
                        {
                            obj.Output();
                            WriteLine();
                        }
                        break;
                    case "7":
                        WriteLine("kết thúc chương trình.");
                        Environment.ExitCode = 0;
                        break;
                    case "8":
                        Write("---Nhập id xe muốn xóa khỏi danh sách: ");
                        string idDel = ReadLine();
                        list.RemoveAll(i =>  i.Id.Equals(idDel));
                        break;
                    case "9":
                        Write("---Nhập id xe muốn sửa: ");
                        string idChange = ReadLine();
                        int count = 0;
                        foreach (Vehicles v in list)
                        {
                            if (v.Id.Equals(idChange)) { count++; }
                        }
                        if (count == 0) Write("-----Không có xe nào có id {0} trong danh sách-----", idChange);
                        else
                        {
                            foreach(Vehicles v in list)
                            {
                                if (v.Id.Equals(idChange))
                                {
                                    v.Input();
                                }
                            }
                            WriteLine("-----Đã sửa xe có id {0}-----", idChange);
                        }
                        break;
                    default:
                        WriteLine("\n____Vui lòng lựa chọn phù hợp____\n");
                        break;
                }
            } while (!choice.Equals("7"));
        }
        static void menu()
        {
            WriteLine("==================== Main Menu ====================");
            WriteLine("\t1. Nhập dữ liệu");
            WriteLine("\t2. Hiển thị dữ liệu");
            WriteLine("\t3. Tìm kiếm theo id");
            WriteLine("\t4. Tìm kiếm theo maker");
            WriteLine("\t5. Sắp xếp theo price");
            WriteLine("\t6. Sắp xếp theo year");
            WriteLine("\t7. Kết thúc");
            WriteLine("        -----Mở rộng (bài 2)-----");
            WriteLine("\t8. Xóa bớt phương tiện theo id");
            WriteLine("\t9. Sửa thông tin phương tiện theo id");
        }
        static void menuAdd()
        {
            WriteLine("\t----- Chọn đối tượng muốn thêm vào danh sách -----");
            WriteLine("1. Car");
            WriteLine("2.Truck");
        }
    }
}