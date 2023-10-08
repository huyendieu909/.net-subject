using static System.Console;
using System;
public class Student
{
	private int studentid;
	private string name;
	private int mark;
	public int Studentid { get { return studentid; } set {  this.studentid = value; } }
	public string Name { get { return name; } set { name = value; } }
	public int Mark { get { return mark; } set { mark = value; } }
	public Student() { }
    public override string ToString()
    {
		return string.Format("{0, -9}{1, 20}{2, 5}", Studentid, Name, Mark);
    }
	public void InputStudent()
	{
		Write("student id: ");
		Studentid = int.Parse(ReadLine());
		Write("student name: ");
		Name = ReadLine();
		Write("student mark: ");
		Mark = int.Parse(ReadLine());
	}
}
