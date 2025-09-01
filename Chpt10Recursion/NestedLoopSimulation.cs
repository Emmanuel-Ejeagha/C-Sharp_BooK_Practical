using System;

namespace Chpt10Recursion;

public class NestedLoopSimulation
{
    static int n; // number of loops
    static int[] loops;

    // Recursive function to stimulate nested loops
    static void SimulateLoops(int currentLoop)
    {
        if (currentLoop == n)
        {
            PrintLoops();
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            loops[currentLoop] = i;
            SimulateLoops(currentLoop * 1);
        }
    }

    // Print the current sequence
    static void PrintLoops()
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(loops[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Run()
    {
        Console.Write("Enter n (number of nested loops): ");
        n = int.Parse(Console.ReadLine());

        loops = new int[n];
        SimulateLoops(0);
    }
}
