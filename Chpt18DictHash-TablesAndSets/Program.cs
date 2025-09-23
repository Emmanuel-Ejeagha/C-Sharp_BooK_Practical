using Chpt18DictHash_TablesAndSets;


// IDictionary<string, double> studentsMarks = new Dictionary<string, double>();

// studentsMarks["Paul"] = 3.00;
// Console.WriteLine("Paul's mark: {0:0.00}", studentsMarks["Paul"]);

// // Call WordCountingWithSortedDictionar
// WordCountingWithSortedDictionary.Run();

// // Hash table example
// IDictionary<string, double> studentMarks = new Dictionary<string, double>(6);
// studentMarks["Alan"] = 3.00;
// studentMarks["Helen"] = 4.0;
// studentMarks["Tom"] = 5.50;
// studentMarks["James"] = 3.50;
// studentMarks["Mary"] = 4.00;
// studentMarks["Nerdy"] = 6.00;

// double marysMark = studentMarks["Mary"];
// Console.WriteLine("Mary's mark: {0:0.00}", marysMark);
// studentMarks.Remove("Mary");

// Console.WriteLine("Mary's mark is removed");

// Console.WriteLine("Is Mary in the dictionary: {0}", studentMarks.ContainsKey("Mary") ? "Yes!" : "No!");

// Console.WriteLine("Merdy's mark is {0:0.00}", studentMarks["Nerdy"]);
// studentMarks["Nerdy"] = 3.25;

// Console.WriteLine("But we know that he deserves no more than {0:0.00}.", studentMarks["Nerdy"]);

// double annasMark;
// bool findAnna = studentMarks.TryGetValue("Anna", out annasMark);

// Console.WriteLine("Is Anna's mark in the dictionary? {0}", findAnna ? "Yes!" : "No!");

// studentMarks["Anna"] = 6.00;
// findAnna = studentMarks.TryGetValue("Anna", out annasMark);

// Console.WriteLine("Let's try again: {0}. Anna's mark is {1}", findAnna ? "Yes!" : "No!", annasMark);

// Console.WriteLine("Students and marks:");

// foreach (System.Collections.Generic.KeyValuePair<string, double> studentMark in studentsMarks)
// {
//     Console.WriteLine("{0} has {1:0.00}", studentMark.Key, studentMark.Value);
// }

// Console.WriteLine("There are {0} students in the dictionary", studentMarks.Count);
// studentMarks.Clear();
// Console.WriteLine("Studenmts dictionary cleared.");
// Console.WriteLine("Is dictionary empty: {0}", studentMarks.Count == 0);

// // Print the hashTable
// IEqualityComparer<Point3D> comparer = new Pointer3DEqualityComparer();
// Dictionary<Point3D, int> dict = new Dictionary<Point3D, int>(comparer);

// dict[new Point3D(4, 2, 5)] = 5;
// dict[new Point3D(1, 2, 3)] = 1;
// dict[new Point3D(3, 1, -1)] = 3;
// dict[new Point3D(1, 2, 3)] = 10;
// foreach (var entry in dict)
// {
//     Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
// }

// // Call the HasHTable method
HashDictionary<Point3D, int>.PrintHashDictionary();

// Call studentListSetExample method
StudentListSetExample.SetExample();

// Call SortedSetsExample Method
SortedSetsExample.SortedSetsEg();