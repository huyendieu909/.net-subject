using System.Text;
using static System.Console;
namespace baitap1
{
    class Employee
    {
        private string id;
        private string name;
        private int age;
        private int workingdays;
        private double salary;
        private static double PRICE = 50;
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public int Workdays { get {  return workingdays; } set {  workingdays = value; } }  
        public double Salary 
        { 
            get {  return workingdays * PRICE; } 
            set 
            {  
                salary = value;
            } 
        }   
        public void Input()
        {
            Write("id: ");
            id = ReadLine();
            Write("name: ");
            name = ReadLine();
            Write("age: ");
            age = int.Parse(ReadLine());
            Write("workingdays: ");
            workingdays = int.Parse(ReadLine());
            salary = Salary;
        }
        public void Output()
        {
            WriteLine($"\tid: {id}");
            WriteLine($"\tname: {name}");
            WriteLine($"\tage: {age}");
            WriteLine($"\tworkingdays: {workingdays}");
            WriteLine($"\tsalary: {salary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.Cyan;
            Employee employee = new Employee();
            Write("====Nhập thông tin nhân viên====\n");
            employee.Input();
            WriteLine("=====Thông tin sinh viên đã nhập=====");
            employee.Output();
        }
    }
}