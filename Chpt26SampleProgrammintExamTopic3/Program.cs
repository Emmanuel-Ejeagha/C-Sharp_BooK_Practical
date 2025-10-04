using Chpt26SampleProgrammintExamTopic3.School;

// Test School
Student studentPeter = new Student("Peter", "Ikechukwu");
Console.WriteLine(studentPeter);

// Test Group
Student studentUche = new Student("Uche", "Uchechukwu");
Student studentEmeka = new Student("Emeka", "Udeh");
Group groupEnglish = new Group("English Language Course");
groupEnglish.Students.Add(studentUche);
groupEnglish.Students.Add(studentEmeka);
Teacher teacherEmma = new Teacher("Emmanuel", "Ejeagha");
groupEnglish.Teacher = teacherEmma;
Console.WriteLine(groupEnglish);

// Test Teacher
Teacher teacherMike = new Teacher("Ebele", "Michael");
Group groupGerman = new Group("German language");
Group groupFrench = new Group("French language");
teacherMike.Groups.Add(groupGerman);
teacherMike.Groups.Add(groupFrench);
Console.WriteLine(teacherMike);

// Test School
TestSchool.RunTestSchool();