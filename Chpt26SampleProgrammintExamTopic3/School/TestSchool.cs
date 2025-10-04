using System;

namespace Chpt26SampleProgrammintExamTopic3.School;

public class TestSchool
{
    public static void RunTestSchool()
    {
        // Create a few students
        Student studentPeter = new Student("Peter", "Lee");
        Student studentGeorge = new Student("George", "Redwood");
        Student studentMaria = new Student("Maria", "Steward");
        Student studentMike = new Student("Michael", "Robinson");
        // Create a group and add a few students to it
        Group groupEnglish = new Group("English language course");
        groupEnglish.Students.Add(studentPeter);
        groupEnglish.Students.Add(studentMike);
        groupEnglish.Students.Add(studentMaria);
        groupEnglish.Students.Add(studentGeorge);
        // Create a group and add a few students to it
        Group groupJava = new Group("Java Programming course");
        groupJava.Students.Add(studentMaria);
        groupJava.Students.Add(studentPeter);
        // Create a teacher and assign it to few groups
        Teacher teacherNatasha = new Teacher("Natasha", "Walters");
        teacherNatasha.Groups.Add(groupEnglish);
        teacherNatasha.Groups.Add(groupJava);
        groupEnglish.Teacher = teacherNatasha;
        groupJava.Teacher = teacherNatasha;
        // Create another teacher and a group he teaches
        Teacher teacherSteve = new Teacher("Steve", "Porter");
        Group groupHTML = new Group("HTML course");
        groupHTML.Students.Add(studentMike);

        groupHTML.Students.Add(studentMaria);
        groupHTML.Teacher = teacherSteve;
        teacherSteve.Groups.Add(groupHTML);
        // Create a school with few students, groups and teachers
        School school = new School("Saint George High School");
        school.Students.Add(studentPeter);
        school.Students.Add(studentGeorge);
        school.Students.Add(studentMaria);
        school.Students.Add(studentMike);
        school.Groups.Add(groupEnglish);
        school.Groups.Add(groupJava);
        school.Groups.Add(groupHTML);
        school.Teachers.Add(teacherNatasha);
        school.Teachers.Add(teacherSteve);
        // Modify some of the groups, student and teachers
        groupEnglish.Name = "Advanced English";
        groupEnglish.Students.RemoveAt(0);
        studentPeter.LastName = "White";
        teacherNatasha.LastName = "Hudson";
        // Print the school
        Console.WriteLine(school);
    }
}
