using System;

namespace Chpt18DictHash_TablesAndSets;

public class SortedSetsExample
{
    public static void SortedSetsEg()
    {
        SortedSet<string> bandBradsLikes = new SortedSet<string>(new[] {
            "Manowar", "Blind Guadian", "Dio", "Kiss", "Dream Theater", "Megadeth", "Judas Priest", "Kreator", "Iron Maiden", "Accept"
        });

        SortedSet<string> bandAngelinaLikes = new SortedSet<String>(new[] {
            "Iron Madian", "Dio", "Accept", "Manowar", "Slayer", "Megadeth", "Running Wild", "Grave Gigger", "Metallica"
         });

        Console.Write("Brad Pitt likes these bands: ");
        Console.WriteLine(string.Join(", ", bandBradsLikes));


        Console.Write("Angelina Bliss likes these bands: ");
        Console.WriteLine(string.Join(", ", bandAngelinaLikes));

        SortedSet<string> intersectBands = new SortedSet<string>(bandBradsLikes);
        intersectBands.IntersectWith(bandAngelinaLikes);

        Console.WriteLine(string.Format("Does Brad Pitt like Angelina Bliss? {0}", intersectBands.Count >= 5 ? "Yes!" : "No!"));

        Console.Write("Because Brad Pitt and Angelina Bliss both like: ");
        Console.WriteLine(string.Join(", ", intersectBands));

        SortedSet<string> unionBands = new SortedSet<string>(bandBradsLikes);
        unionBands.UnionWith(bandAngelinaLikes);

        Console.Write("All bands that Brad Pitt or Angelina Bliss like: ");
        Console.WriteLine(string.Join(", ", unionBands));
    }
}
