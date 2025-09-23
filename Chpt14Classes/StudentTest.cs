using System;

namespace Chpt14Classes;

public class StudentTest
{
    // Static field to hold students
    private static List<Student> students = new List<Student>();

    // Static property to access them
    public static List<Student> Students
    {
        get { return students; }
    }

    // Static method to create some students
    public static void CreateStudents()
    {
        students.Add(new Student("Emmanuel King", "Computer Science"));
        students.Add(new Student("Bob Smith", "Mathematics", "Algebra", "MIT", "bobsmith@mit.edu", "123-456-7890"));
        students.Add(new Student("Elon Musk"));
    }

    public static void PrintStudents()
    {
        foreach (var student in students)
        {
            student.DisplayInfo();

        }
        Console.WriteLine($"Total Students: {Student.StudentCount}");
    }
}
