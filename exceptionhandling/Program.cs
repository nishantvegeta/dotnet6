using System;
using System.Collections.Generic;
using System.Linq;

namespace exceptionhandling
{
    class Program
    {
        static List<Student> students = new List<Student>
        {
            new Student(1, "nishant", true),
            new Student(2, "sudip", false),
            new Student(3, "raytish", true)
        };

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter student id: ");
                int studentid = Convert.ToInt32(Console.ReadLine());

                Student student = GetStudentById(studentid);
                Console.WriteLine($"Student {student.Name} is enrolled.");
            }
            catch (StudentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Student GetStudentById(int id)
        {
            Student student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                throw new ArgumentException($"Student with ID {id} not found");
            }
            if (!student.IsEnrolled)
            {
                throw new StudentException($"Student {student.Name} with ID {student.Id} is not enrolled");
            }
            return student;
        }
    }
}