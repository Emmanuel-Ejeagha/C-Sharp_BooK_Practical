using Chpt19DSA;

string[] words = { "ocean", "beer", "money", "happiness" };
Queue<HashSet<string>> subsetQueue = new Queue<HashSet<string>>();
HashSet<string> emptySet = new HashSet<string>();
subsetQueue.Enqueue(emptySet);
while (subsetQueue.Count > 0)
{
    HashSet<string> subset = subsetQueue.Dequeue();

    // Print current subset
    Console.Write("{");
    foreach (string word in subset)
    {
        Console.Write("{0} ", word);
    }
    Console.WriteLine("}");

    // Generate and enqueue all posible child subsets
    foreach (string element in words)
    {
        if (!subset.Contains(element))
        {
            HashSet<string> newSubset = new HashSet<string>();
            newSubset.UnionWith(subset);
            newSubset.Add(element);
            subsetQueue.Enqueue(newSubset);
        }
    }
}
Console.WriteLine("Generating all subsets:");
Console.WriteLine("=======================");
SubsetsDSA.Subsets();


Console.WriteLine("\nAll Courses and students subsets:");
Console.WriteLine("=======================");
// invoke PrintCoursesAndStudent
Student.PrintCoursesAndStudent();

Console.WriteLine("\nPhone Book Sorting:");
Console.WriteLine("=======================");
// Call PhonebooksSorting Method
PhonebookSorting.PrintPhoneBook();

Console.WriteLine("Phone Book Finder:");
Console.WriteLine("=======================");
//  Call PhoneBookFinder Method
PhoneBookFinder.ReadPhoneBook();
PhoneBookFinder.ProcessQueries();