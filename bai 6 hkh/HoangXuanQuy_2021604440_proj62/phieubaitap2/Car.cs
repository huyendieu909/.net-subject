using System;
using static System.Console;
namespace phieubaitap2
{
    internal class Car : Vehicles
    {
        private string color;
        public string Color { get { return color; } set { color = value; } }
        public Car() { }
        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }
        public override void Input()
        {
            base.Input();
            Write("color: ");
            Color = ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Write("{0, 10}", Color);
        }
    }

}
