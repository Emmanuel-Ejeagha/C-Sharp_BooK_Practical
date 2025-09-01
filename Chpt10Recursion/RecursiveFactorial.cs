using System;

namespace Chpt10Recursion;

public class RecursiveFactorial
{
    public static decimal FactorialCalc(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * FactorialCalc(n - 1);
        }
    }

    public static void PrintFactorial()
    {
        Console.WriteLine("Enter a number to calculate its factorial");
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        decimal fact = FactorialCalc(n);
        Console.WriteLine($"Factorial of {n} is {fact}");

    }
}
