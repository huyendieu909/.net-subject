using System.Text;
using static System.Console;
namespace baitap3
{
    internal class Program
    {
        class Student
        {
            private string id;
            private string name;
            private int mark;
            private int scholarship;
            public string Id { get { return id; } set { id = value; } }
            public string Name { get { return name; } set { name = value; } }
            public int Mark { get { return mark; } set { mark = value; } }
            public int Scholarship { get { return scholarship; } set { scholarship = value; } }
            public int calScholarship()
            {
                if (mark > 8) return 500;
                else if (mark >= 7) return 300;
                else return 0;
            }
            public Student() { }
            public Student(string id)
            {
                this.id = id;
            }
            public Student(string id, string name, int mark)
            {
                this.id = id;
                this.name = name;
                this.mark = mark;
                this.scholarship = calScholarship();
            }
            public void Input()
            {
                Write("Id: ");
                id = ReadLine();
                Write("Tên: ");
                name = ReadLine();
                Write("Điểm: ");
                mark = int.Parse(ReadLine());
                scholarship = calScholarship();
            }
            public void Output()
            {
                WriteLine("\tId: {0}", Id);
                WriteLine($"\tTên: {Name}");
                WriteLine($"\tĐiểm: {Mark}");
                WriteLine($"\tHọc bổng: {Scholarship}");
            }
        }
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Cyan;
            OutputEncoding = Encoding.UTF8;
            //test khởi tạo không tham số
            WriteLine("Nhập thông tin sinh viên thứ nhất");
            Student student1 = new Student();
            student1.Input();
            WriteLine("\t=====Sinh viên thứ nhất=====");
            student1.Output();
            //test khởi tạo một tham số
            Student student2 = new Student("2021600002");
            WriteLine("Nhập thông tin cho sinh viên thứ 2");
            Write("tên: ");
            student2.Name = ReadLine();
            Write("điểm: ");
            student2.Mark = int.Parse(ReadLine());
            student2.Scholarship = student2.calScholarship();
            WriteLine("\n\t=====Sinh viên thứ hai=====");
            student2.Output();
            //test khởi tạo full tham số
            Student student3 = new Student("2021600003", "Dương Huy Khôi", 10);
            WriteLine("\n\t=====Sinh viên thứ ba=====");
            student3.Output();
        }
    }
}