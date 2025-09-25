public static class PhonebookSorting
{
    private static SortedDictionary<string, SortedDictionary<string, string>> phonesByTown =
        new SortedDictionary<string, SortedDictionary<string, string>>();

    public static void LoadPhonebook()
    {
        StreamReader reader = new StreamReader("Phonebook.txt");
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
                string name = entry[0].Trim();
                string town = entry[1].Trim();
                string phone = entry[2].Trim();

                SortedDictionary<string, string> phoneBook;
                if (!phonesByTown.TryGetValue(town, out phoneBook))
                {
                    // This town is new. Create a phone book for it
                    phoneBook = new SortedDictionary<string, string>();
                    phonesByTown.Add(town, phoneBook);
                }
                phoneBook.Add(name, phone);
            }
        }
    }

    // Print the phonebook by towns
    public static void PrintPhoneBook()
    {
        // Load the data first if not already loaded
        if (phonesByTown.Count == 0)
        {
            LoadPhonebook();
        }

        foreach (string town in phonesByTown.Keys)
        {
            Console.WriteLine("Town " + town + ":");
            SortedDictionary<string, string> phoneBook = phonesByTown[town];
            foreach (var entry in phoneBook)
            {
                string name = entry.Key;
                string phone = entry.Value;
                Console.WriteLine("\t{0} - {1}", name, phone);
            }
        }
    }
}