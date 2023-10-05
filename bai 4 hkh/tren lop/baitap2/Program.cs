using System.Text;
using static System.Console;

namespace baitap2
{
    internal class Program
    {
        class Circle
        {
            private double radius;
            public double Radius { get { return radius; } set { radius = value; } }
            public Circle() { }
            public Circle(double radius)
            {
                this.radius = radius;
            }
            public double Area()
            {
                return radius * radius * Math.PI;
            }
            public double Perimeter()
            {
                return 2 * radius * Math.PI;
            }
            public void Input()
            {
                Write("Nhập bán kính cho hình tròn: ");
                this.radius = int.Parse(ReadLine());
            }
        }
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.Cyan;
            // test khởi tạo không tham số
            WriteLine("=====Hình tròn thứ nhất=====");
            Circle circle1 = new Circle();
            circle1.Input();
            WriteLine($"Chu vi: " + circle1.Perimeter());
            WriteLine("Diện tích: {0}", circle1.Area());
            // test khởi tạo một tham số
            WriteLine("\n=====Hình tròn thứ hai=====");
            Circle circle2 = new Circle(2);
            WriteLine("Bán kính: {0}", circle2.Radius);
            WriteLine("Chu vi: {0}", circle2.Perimeter());
            WriteLine($"Diện tích: {circle2.Area()}");
        }
    }
}