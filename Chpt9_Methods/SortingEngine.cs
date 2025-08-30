using System;

namespace Chpt9_Methods;

public class SortingEngine
{
    public static int[] Sort(params int[] numbers)
    {
        // Thhe sorting logic:
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            // Loop that is operating over the unsorted part of the array
            for (int j = i + 1; j < numbers.Length; j++)
            {
                // Swapping the values
                if (numbers[i] > numbers[j])
                {
                    int oldNum = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = oldNum;
                }
            }
        } // End of the sorting Logic
        return numbers;
    }

    public static void PrintNumbers(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}", numbers[i]);
            if (i < (numbers.Length - 1))
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
