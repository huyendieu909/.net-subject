using System;
using static System.Console;
public class  Course : IEquatable<Course>
{
	private string courseid;
	private string courseName;
	private int fee;
	List<Student> li;
	public string Courseid { get { return courseid; } set { courseid = value; } }
	public string CourseName { get { return courseName; } set { courseName = value; } }
	public int Fee { get { return fee; } set { fee = value; } }
	public Course() 
	{ 
		li = new List<Student>();
	}
	public void InputCourse()
	{
		Write("course id: ");
		Courseid = ReadLine();
		Write("course name: ");
		CourseName = ReadLine();
		Write("course fee: ");
		fee = int.Parse(ReadLine());
		Write("Nhập số sinh viên cho khóa học này: ");
		int n = int.Parse(ReadLine());
		for (int i=0;i<n; i++)
		{
            WriteLine("-----");
            Student student = new Student();
			student.InputStudent();
			li.Add(student);
		}
	}
	public void DisplayCourseAndStudents()
	{
		WriteLine("\t---------- Course Information ----------");
        WriteLine($"course id: {Courseid}");
		WriteLine($"course name: {CourseName}");
		WriteLine($"course fee: {Fee}");
		WriteLine("{0, -6}{1, -20}{2, 6}", "sid", "name", "mark");
		li.ForEach(li => { WriteLine("{0, -6}{1, -20}{2, 6}", li.Studentid, li.Name, li.Mark); });
	}
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
		Course course = obj as Course;
		if (course == null) return false;
		return Equals(course);
    }
	public bool Equals(Course other)
	{
		if (other == null) return false;
		return (this.Courseid.Equals(other.Courseid));
	}
    public void DisplayCourseAndStudentsByStudentId(int studentid)
    {
        WriteLine("\t---------- Course Information ----------");
        WriteLine($"course id: {Courseid}");
        WriteLine($"course name: {CourseName}");
        WriteLine($"course fee: {Fee}");
        WriteLine("{0, -6}{1, -20}{2, 6}", "sid", "name", "mark");
		foreach (Student s in li)
		{
			if (s.Studentid == studentid)
			{
				WriteLine("{0, -6}{1, -20}{2, 6}", s.Studentid, s.Name, s.Mark);
			}
		}
    }
	public int HaveStudentIdInList(int studentid)
	{
		foreach (Student student in li)
		{
			if (student.Studentid == studentid) return 1;
		}
		return 0;
	}
}
