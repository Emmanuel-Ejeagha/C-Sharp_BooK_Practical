using System;

namespace Chpt10Recursion;

public class Fibonacci
{
    public static int Fib(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        return Fib(n - 1) + Fib(n - 2);
    }

    public static void PrintFib(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.Write(Fib(i) + " ");
        }
        Console.WriteLine();
    }
}
