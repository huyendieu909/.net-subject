using System.Text;
using static System.Console;
namespace phieubaitap1
{
    internal class Program
    {
        static List<Student> students = new List<Student>();   
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
                        WriteLine("\t-----Nhập thông tin sinh viên cần thêm-----");
                        Student student = new Student();
                        student.Input();
                        students.Add(student);
                        WriteLine("\t---Đã thêm---");
                        break;
                    case "2":
                        WriteLine("\t-----Danh sách sinh viên-----");
                        WriteLine("{0, -5} {1, 20} {2,20}    {3, 4} {4, 4}" , "Id", "Name", "Address", "Maths", "Physics");
                        foreach(Student s in students)
                        {
                            s.Output();
                            WriteLine();
                        }
                        WriteLine("---Done---\n");
                        break;
                    case "3":
                        Write("Nhập id sinh viên cần tìm kiếm: ");
                        int idSearch = int.Parse(ReadLine());
                        WriteLine("\t-----Các sinh viên tìm được-----");
                        WriteLine("{0, -5} {1, 20} {2,20}    {3, 4} {4, 4}", "Id", "Name", "Address", "Maths", "Physics");
                        foreach (Student s in students)
                        {
                            if (s.Id == idSearch)
                            {
                                s.Output();
                                WriteLine();
                            }
                        }
                        WriteLine("\t-----Done-----\n");    
                        break;
                    case "4":
                        Write("Nhập địa chỉ sinh viên cần tìm kiếm: ");
                        string adrSearch = ReadLine();
                        WriteLine("\t-----Các sinh viên tìm được-----");
                        WriteLine("{0, -5} {1, 20} {2,20}    {3, 4} {4, 4}", "Id", "Name", "Address", "Maths", "Physics");
                        foreach (Student s in students)
                        {
                            if (s.Equals(adrSearch))
                            {
                                s.Output();
                                WriteLine();
                            }
                        }
                        WriteLine("-----Done-----\n");
                        break;
                    case "5":
                        Write("Nhập id sinh viên cần xóa: ");
                        int idDel = int.Parse(ReadLine());
                        students.RemoveAll(i => i.Id == idDel);
                        WriteLine("-----Đã xóa sinh viên có id {0} trong danh sách-----\n", idDel);
                        break;
                    case "6":
                        WriteLine("-----kết thúc chương trình.-----");
                        Environment.Exit(0);    
                        break;
                }
            } while (!choice.Equals("6"));
        }
        static void menu()
        {
            WriteLine("=====Main menu=====");
            WriteLine("1. Thêm 1 sinh viên");
            WriteLine("2. Hiển thị danh sách sinh viên");
            WriteLine("3. Tìm kiếm sinh viên theo id");
            WriteLine("4. Tỉm kiếm sinh viên theo address");
            WriteLine("5. Xóa một sinh viên theo address");
            WriteLine("6. Kết thúc chương trình");
        }
    }
}