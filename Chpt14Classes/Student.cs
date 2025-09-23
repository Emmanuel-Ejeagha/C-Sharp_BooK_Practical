
using System;

namespace Chpt14Classes;

public class Student
{
    // Fields (private and encapsulated)
    private string fullName;
    private string? course;
    private string? subject;
    private string? university;
    private string? email;
    private string? phoneNumber;

    // Static field to count how many students were created
    private static int studentCount = 0;

    // Constructor with all info
    // Static property to get number of created students
    public static int StudentCount
    {
        get { return studentCount; }
    }

    // Properties (encapsulation)
    public string FullName
    {
        get { return fullName; }
        set { fullName = value; }
    }

    public string? Course { get; set; }
    public string? Subject { get; set; }
    public string? University { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }

    public Student(string fullName, string? course, string? subject, string university, string? email, string? phoneNumber)
    {
        this.FullName = fullName;
        this.Course = course;
        this.Subject = subject;
        this.University = university;
        this.Email = email;
        this.PhoneNumber = phoneNumber;
        studentCount++;
    }

    // Constructor with only full name
    public Student(string fullName) : this(fullName, null, null, null, null, null) { }

    //  Constructor with full name and course
    public Student(string fullName, string course) : this(fullName, course, null, null, null, null) { }

    // Method to display infor
    public void DisplayInfo()
    {
        Console.WriteLine("----- Student Info -----");
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Course: {Course ?? "N/A"}");
        Console.WriteLine($"Subject: {Subject ?? "N/A"}");
        Console.WriteLine($"University: {University ?? "N/A"}");
        Console.WriteLine($"Email: {Email ?? "N/A"}");
        Console.WriteLine($"Phone: {PhoneNumber ?? "N/A"}");
        Console.WriteLine();
    }

}
