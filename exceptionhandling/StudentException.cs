using System;
namespace exceptionhandling;

public class StudentException : Exception
{
    public StudentException() : base("Student is not enrolled") { }

    public StudentException(string message) : base(message) { }

    public StudentException(string message, Exception innerException) : base(message, innerException) { }

}
