using System.Text;

namespace baitap1
{
    internal class Program
    {
        class Person
        {
            private string id;
            private string name;    
            private int age;
            private string email;
            private string address;
            public string Id { get { return id; } set { id = value; } }
            public string Name { get { return name; } set { name = value;} }
            public int Age { get { return age;} set { age = value;} }
            public string Email { get { return email; } set { email = value;} }
            public string Address { get { return address; } set { address = value;} }
            public Person()
            {
                id = "DEFAULT_ID";
                name = "DEFAULT_NAME";
                age = 0;
                Email = string.Empty;
                Address = string.Empty;
            }
            public void CheckAge ()
            {
                if (this.Age >= 18) Console.WriteLine("Bạn đủ tuổi bầu cử");
                else Console.WriteLine("Bạn còn nhỏ");
            }
            public void Input()
            {
                try
                {
                    Console.Write("id: ");
                    id = Console.ReadLine();
                    Console.Write("name: ");
                    name = Console.ReadLine();
                    Console.Write("age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("email: ");
                    email = Console.ReadLine();
                    Console.Write("address: ");
                    address = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            public void Output()
            {
                Console.WriteLine("============ Personal information ==============");
                Console.WriteLine("\tid: " + id);
                Console.WriteLine("\tname: " + name);
                Console.WriteLine("\tage: " + age);
                Console.WriteLine("\temail: " + email);
                Console.WriteLine("\taddress: " + address);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Person person = new Person();
            person.Input();
            person.Output();
            person.CheckAge();
        }
    }
}