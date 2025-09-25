using System;

namespace Chpt19DSA;

public class SubsetsDSA
{
    static string[] words = { "ocean", "beer", "money", "happiness" };

    public static void Subsets()
    {
        Queue<List<int>> subsetQueue = new Queue<List<int>>();
        List<int> emptySet = new List<int>();
        subsetQueue.Enqueue(emptySet);
        while (subsetQueue.Count > 0)
        {
            List<int> subset = subsetQueue.Dequeue();
            Print(subset);
            int start = -1;
            if (subset.Count > 0)
            {
                start = subset[subset.Count - 1];
            }
            for (int i = start + 1; i < words.Length; i++)
            {
                List<int> newSubset = new List<int>();
                newSubset.AddRange(subset);
                newSubset.Add(i);
                subsetQueue.Enqueue(newSubset);
            }
        }
    }

    public static void Print(List<int> subset)
    {
        Console.Write("[ ");
        for (int i = 0; i < subset.Count; i++)
        {
            int index = subset[i];
            Console.Write("{0} ", words[index]);
        }
        Console.WriteLine("]");
    }
}
