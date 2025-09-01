using System;

namespace Chpt10Recursion;

// Recursive Nested Loop Method
public class RecursiveNestedLoops
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;

    public static void NestedLoops(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }

        for (int counter = 1; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1);
        }
    }

    // Print Loops
    public static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write($"{loops[i]} ");
        }
        Console.WriteLine();

    }

    public static void Run()
    {
        Console.Write("N = ");
        numberOfLoops = int.Parse(Console.ReadLine());

        Console.Write("K = ");
        numberOfIterations = int.Parse(Console.ReadLine());

        loops = new int[numberOfLoops];

        NestedLoops(0);
    }
}
