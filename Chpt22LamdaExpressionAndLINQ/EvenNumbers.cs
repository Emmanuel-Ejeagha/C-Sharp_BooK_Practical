using System;

namespace Chpt22LamdaExpressionAndLINQ;

public class EvenNumbers
{
    public static void FrindPrimeNumbers()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> evenMunbers = list.FindAll(x => (x % 2) == 0);

        foreach (var num in evenMunbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
}
