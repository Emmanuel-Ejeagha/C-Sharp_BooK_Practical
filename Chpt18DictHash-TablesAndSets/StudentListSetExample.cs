using System;

namespace Chpt18DictHash_TablesAndSets;

public class StudentListSetExample
{
    public static void SetExample()
    {
        HashSet<string> aspNetStudents = new HashSet<string>();
        aspNetStudents.Add("E. Musk");
        aspNetStudents.Add("C. Charris");
        aspNetStudents.Add("S. Jobs");
        aspNetStudents.Add("L. Page");

        HashSet<string> CSharpStudents = new HashSet<string>();
        CSharpStudents.Add("B. Gates");
        CSharpStudents.Add("C. Awuzie");
        CSharpStudents.Add("E. Ejeagha");
        CSharpStudents.Add("E. Musk");

        HashSet<string> allStudents = new HashSet<string>();
        allStudents.UnionWith(aspNetStudents);
        allStudents.UnionWith(CSharpStudents);

        HashSet<string> intersectStudents = new HashSet<string>(aspNetStudents);
        intersectStudents.IntersectWith(CSharpStudents);

        Console.WriteLine("ASP.NET students: " + string.Join(", ", aspNetStudents));
        Console.WriteLine("CSharp students: " + string.Join(", ", CSharpStudents));
        Console.WriteLine("All students: " + string.Join(", ", allStudents));
        Console.WriteLine("Students in both ASP.NET and CSharp: " + string.Join(", ", intersectStudents));
    }
}
