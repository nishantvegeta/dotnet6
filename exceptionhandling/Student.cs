namespace exceptionhandling;

public class Student
{
    public int Id{ get; set; }
    public string Name { get; set; }
    public bool IsEnrolled { get; set; }

    public Student(int id, string name, bool isEnrolled)
    {
        Id = id;
        Name = name;
        IsEnrolled = isEnrolled;
    }
}
