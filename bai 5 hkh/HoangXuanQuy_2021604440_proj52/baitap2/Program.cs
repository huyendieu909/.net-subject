using System.Text;
using static System.Console;
namespace baitap2
{
    class GiaiPhuongTrinhBac2
    {
        private int a;
        private int b;
        private int c;
        public int A { get { return a; } set { a = value;} }
        public int B { get { return b; } set { b = value;} }
        public int C { get { return c; } set { c = value;} }
        public GiaiPhuongTrinhBac2 () { }
        public GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Solve()
        {
            int delta = b*b - 4*a*c;
            if (delta < 0) WriteLine("Phương trình vô nghiệm");
            else if (delta == 0) WriteLine($"Phương trình đã cho có nghiệm kép: x = {-b / (2 * a)}");
            else WriteLine($"Phương trình đã cho có 2 nghiệm phân biệt: \n\tx1 = {(-b - Math.Sqrt(delta)) / (2 * a)}\n\tx2 = {(-b + Math.Sqrt(delta)) / (2 * a)}");
        }
        public void Input()
        {
            Write("a: ");
            a = int.Parse(ReadLine());
            Write("b: ");
            b = int.Parse(ReadLine());
            Write("c: ");
            c = int.Parse(ReadLine());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;
            ForegroundColor = ConsoleColor.Cyan;
            GiaiPhuongTrinhBac2 g = new GiaiPhuongTrinhBac2 ();
            WriteLine ("=====Nhập a, b, c của phương trình bậc 2=====");
            g.Input();
            WriteLine("=====Kết quả=====");
            g.Solve();
        }
    }
}