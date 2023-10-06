using System;
using static System.Console;
public class Person
{
	private int id;
	private string name;
	private string address;
	public int Id { get { return id; } set { id = value; } }
	public string Name { get { return name; } set { name = value; } }
	public string Address { get { return address; } set { address = value; } }
	public Person() { }
	public Person(string name, string address)
	{
		this.name = name;
		this.address = address;
	}
	public void Input()
	{
		Write("id: ");
		Id = int.Parse(ReadLine());
		Write("name: ");
		Name = ReadLine();
		Write("address: ");
		Address = ReadLine();
	}
	public void Output()
	{
		Write("{0, -5} {1, 20} {2,20} ", Id, Name, Address);
	}
}
