using System;

namespace Chpt26SampleProgrammintExamTopic3.School;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string Name
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    public override string ToString()
    {
        return $"Student: {Name}";
    }
}
