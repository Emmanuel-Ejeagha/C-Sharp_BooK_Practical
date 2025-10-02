using System;

namespace Chpt23MethodologyOfProblemSolving;

public class Sort1000Numbers
{

    public static void Sort1000NumbersRandomly()
    {
        int[] numbers = new int[1000];
        Random rnd = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(2 * numbers.Length);
        }
        SortNumbers(numbers);
        PrintNumbers(numbers);
    }

    static void SortNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            int oldNumber = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = oldNumber;
        }
    }

    static void PrintNumbers(int[] numbers)
    {
        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
