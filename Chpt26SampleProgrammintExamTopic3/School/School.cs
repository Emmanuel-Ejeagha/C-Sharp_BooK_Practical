using System;
using System.Text;

namespace Chpt26SampleProgrammintExamTopic3.School;

public class School
{
    public string Name { get; set; }
    public List<Teacher> Teachers { get; set; }
    public List<Group> Groups { get; set; }
    public List<Student> Students { get; set; }

    public School(string name)
    {
        Name = name;
        Teachers = new List<Teacher>();
        Groups = new List<Group>();
        Students = new List<Student>();
    }

    public override string ToString()
    {
        StringBuilder schoolAsString = new StringBuilder();
        schoolAsString.AppendLine("School name: " + this.Name);
        schoolAsString.AppendLine("Teachers: " + string.Join(", ", Teachers.Select(x => x.Name)));
        schoolAsString.AppendLine("Students: " + string.Join(", ", Students.Select(s => s.Name)));
        schoolAsString.Append("Groups: " + string.Join(", ", Groups.Select(x => x.Name)));
        foreach (var teacher in this.Teachers)
        {
            schoolAsString.Append("\n---\n");
            schoolAsString.Append(teacher);
        }
        foreach (var group in this.Groups)
        {
            schoolAsString.Append("\n---\n");
            schoolAsString.Append(group);
        }
        foreach (var student in this.Students)
        {
            schoolAsString.Append("\n---\n");
            schoolAsString.Append(student);
        }
        return schoolAsString.ToString();

    }
}

public class Teacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Group> Groups { get; set; }

    public Teacher(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Groups = new List<Group>();
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
        StringBuilder teacherAsString = new StringBuilder();
        teacherAsString.AppendLine("Teacher's name: " + Name);
        teacherAsString.Append("Groups of this teacher: " + string.Join(", ", Groups.Select(s => s.Name)));
        return teacherAsString.ToString();
    }
}

public class Group
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public Teacher Teacher { get; set; }

    public Group(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    public override string ToString()
    {
        StringBuilder groupAsString = new StringBuilder();
        groupAsString.AppendLine($"Group name: {Name}");
        groupAsString.Append($"Students in the group: {string.Join(", ", Students.Select(s => s.Name))}");
        if (Teacher != null)
        {
            groupAsString.Append($"\nGroup Teacher: {Teacher.Name}");
        }
        return groupAsString.ToString();
    }
}
