using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Chpt22LamdaExpressionAndLINQ;

public class LINQQueryPlayground
{
    public static void PrintNumbers()
    {
        // from culture in CultureInfo.GetCultures(CultureTypes)
        // where culture.Name.StartsWith("b");
        List<int> numbers = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12,
        };
        var evenNumbers =
            from num in numbers
            where num % 2 == 0
            select num;
        foreach (var number in evenNumbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    public static void PrintSortedElements()
    {
        string[] words = { "cherry", "apple", "blueberry" };
        var wordsSortedByLength =
            from word in words
            orderby word.Length descending
            select word;
        foreach (var word in wordsSortedByLength)
        {
            Console.WriteLine(word);
        }
    }

    public static void NumberGrouping()
    {
        int[] numbers =
        {5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 12, 13};
        int divisor = 5;

        var numberGroups =
            from number in numbers
            group number by number % divisor into groups
            select new { Remainder = groups.Key, Numbers = groups };

        foreach (var group in numberGroups)
        {
            Console.WriteLine(
                $"Numbers with a remainder of {group.Remainder} when divided by {divisor}:"
            );
            foreach (var number in group.Numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
