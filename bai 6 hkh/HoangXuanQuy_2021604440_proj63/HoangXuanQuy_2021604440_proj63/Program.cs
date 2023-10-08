using System.Text;
using static System.Console;
namespace HoangXuanQuy_2021604440_proj63
{
    internal class Program
    {
        static List<Course> courses = new List<Course>();
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.Cyan;
            string choose = "";
            do
            {
                menu();
                Write("Your choice: ");
                choose = ReadLine();
                switch(choose)
                {
                    case "1":
                        Course course = new Course();
                        course.InputCourse();
                        courses.Add(course);
                        Write("\n-----Đã thêm một khóa học-----\n\n");
                        break;
                    case "2":
                        WriteLine("--------- Các khóa học ---------");
                        courses.ForEach(c => c.DisplayCourseAndStudents());
                        break;
                    case "3":
                        Write("___Nhập vào mã khóa học cần tìm kiếm: ");
                        string idSearch = ReadLine();
                        if (!courses.Contains(new Course { Courseid = idSearch })) WriteLine("\n----- Không có khóa học nào có id {0} -----\n", idSearch);
                        else
                        {
                            foreach (Course c in courses)
                            {
                                if (c.Courseid.Equals(idSearch))
                                {
                                    c.DisplayCourseAndStudents();
                                }
                            }
                        }
                        break;
                    case "4":
                        Write("___Nhập vào mã sinh viên cần tìm kiếm: ");
                        int idSvSearch = int.Parse(ReadLine());
                        int count = 0;
                        foreach (Course c in courses)
                        {
                            count += c.HaveStudentIdInList(idSvSearch);
                        }
                        if (count == 0) WriteLine("\n----- Không có khóa học nào có sinh viên có mã {0} -----\n", idSvSearch);
                        else
                        {
                            WriteLine($"\n\t----- Tìm thấy {count} sinh viên có mã {idSvSearch} trong các khóa học -----");
                            foreach (Course c in courses)
                            {
                                if (c.HaveStudentIdInList(idSvSearch) != 0)
                                {
                                    c.DisplayCourseAndStudentsByStudentId(idSvSearch);
                                }
                            }
                        }
                        break;
                    case "5":
                        Write("___Nhập vào mã khóa học muốn xóa khỏi danh sách: ");
                        string idCDel = ReadLine();
                        if (!courses.Contains(new Course { Courseid = idCDel })) WriteLine($"\n\t----- Không có khóa học nào có id {idCDel} trong danh sách -----\n");
                        else
                        {
                            courses.RemoveAll(c => c.Courseid.Equals(idCDel));
                            WriteLine($"\n\t----- Đã xóa khóa học có mã {idCDel} khỏi danh sách -----\n");
                        }
                        break;
                    case "6":
                        WriteLine("\t=====Kết thúc chương trình =====");
                        Environment.Exit(0);
                        break;
                    default:
                        WriteLine("\n----- Vui lòng lựa chọn chính xác -----\n");
                        break;
                }
            } while (!choose.Equals("6"));
        }
        static void menu()
        {
            WriteLine("=============== Main menu ==============");
            WriteLine("1. Thêm một khóa học");
            WriteLine("2. Hiển thị các khóa học");
            WriteLine("3. Tìm kiếm khóa học");
            WriteLine("4. Tìm kiếm sinh viên");
            WriteLine("5. Xóa một khóa học");
            WriteLine("6. Kết thúc chương trình");
        }
    }
}