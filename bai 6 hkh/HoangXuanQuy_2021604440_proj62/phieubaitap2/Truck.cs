using System;
using System.Drawing;
using static System.Console;
namespace phieubaitap2
{
    internal class Truck : Vehicles
    {
        private int truckload;
        public int Truckload { get { return truckload; } set { truckload = value; } }
        public Truck() { }
        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.Truckload = truckload;
        }
        public override void Input()
        {
            base.Input();
            Write("truck load: ");
            Truckload = int.Parse(ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Write("{0, 10}{1, 10}", " ", Truckload);
        }
    }

}