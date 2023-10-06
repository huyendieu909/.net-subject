using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace phieubaitap1
{
    internal class Student:Person
    {
        private byte maths;
        private byte physics;
        public byte Maths { get { return maths; } set {  maths = value; } }
        public byte Physics { get {  return physics; } set {  physics = value; } }
        public new void Input()
        {
            base.Input();
            Write("maths: ");
            Maths = Convert.ToByte(ReadLine());
            Write("physics: ");
            physics = Convert.ToByte(ReadLine());
        }
        public new void Output()
        {
            base.Output();
            Write(" {0, 4} {1, 8}", Maths, Physics);
        }
        public byte TongDiem()
        {
            return (byte)(Maths + Physics);
        }
        public Student() { }
        public Student(string name, string address, byte maths, byte physics) : base(name,address)
        {
            Maths = maths;
            Physics = physics;
        }
        public override bool Equals(object? obj)
        {
            return Address.Equals(obj);
        }
    }
}
