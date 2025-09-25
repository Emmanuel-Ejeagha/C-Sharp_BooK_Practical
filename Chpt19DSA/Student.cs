using System;
using System.Collections.Generic;
using System.IO;

namespace Chpt19DSA;

public class Student : IComparable<Student>
{
    private string firstName;
    private string lastName;
    private static Dictionary<string, List<Student>> courses = new Dictionary<string, List<Student>>();

    public Student(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public int CompareTo(Student student)
    {
        int result = lastName.CompareTo(student.lastName);
        if (result == 0)
        {
            result = firstName.CompareTo(student.firstName);
        }
        return result;
    }

    public override string ToString()
    {
        return firstName + " " + lastName;
    }

    // Read the file and build the hash-table of courses
    public static void ReadFile()
    {
        StreamReader reader = new StreamReader("Students.txt");
        using (reader)
        {
            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                string[] entry = line.Split(new char[] { '|' });
                string firstName = entry[0].Trim();
                string lastName = entry[1].Trim();
                string course = entry[2].Trim();
                List<Student> students;
                if (!courses.TryGetValue(course, out students!))
                {
                    // New course -> create a list of students for it 
                    students = new List<Student>();
                    courses.Add(course, students);
                }
                Student student = new Student(firstName, lastName);
                students.Add(student);
            }
        }
    }

    public static void PrintCoursesAndStudent()
    {
        Student.ReadFile();
        foreach (var courseEntry in courses)
        {
            string courseName = courseEntry.Key;
            List<Student> students = courseEntry.Value;

            Console.WriteLine("Course " + courseName + ":");
            students.Sort();
            foreach (Student student in students)
            {
                Console.WriteLine("\t{0}", student);
            }
            Console.WriteLine(); // Add empty line between courses
        }
    }
}