using System;
using System.Collections;
using static System.Console;
namespace phieubaitap2
{
    interface IVehicle
    {
        void Input();
        void Output();
    }      
    internal class Vehicles : IVehicle, IComparable
    {
        private string id;
        private string maker;
        private string model;
        private int year;
        private double price;
        public string Id { get { return id; } set { id = value; } }
        public string Maker { get { return maker; } set { maker = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double Price { get { return price; } set { price = value; } }
        public Vehicles() { }
        public Vehicles(string id)
        {
            this.id = id;
        }
        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public virtual void Input()
        {
            Write("id: ");
            Id = ReadLine();
            Write("maker: ");
            Maker = ReadLine();
            Write("model: ");
            Model = ReadLine();
            Write("year: ");
            Year = int.Parse(ReadLine());
            Write("price: ");
            Price = double.Parse(ReadLine());
        }
        public virtual void Output()
        {
            Write("{0, -6}{1, 15}{2, 15}{3, 8}{4, 10}", Id, Maker, Model, Year, Price);
        }
        public override bool Equals(object? obj)
        {
            Vehicles objVehicles = obj as Vehicles;
            return Id.Equals(objVehicles.Id);
        }
        public override string ToString()
        {
            return string.Format("{0, -6}{1, 15}{2, 15}{3, 8}{4, 10}", Id, Maker, Model, Year, Price);
        }

        public int CompareTo(object? obj)
        {
            Vehicles v = obj as Vehicles;
            return Price.CompareTo(v.Price);
        }
        
    }
}
