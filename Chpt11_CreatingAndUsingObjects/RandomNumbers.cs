using System;

namespace Chpt11CreatingAndUsingObjects;

public class RandomNumbers
{
    public static void PrintRandomNumbers()
    {

        Random rand = new Random();
        for (int number = 1; number <= 6; number++)
        {
            int randomNumber = rand.Next(19) + 1;
            Console.Write($"{randomNumber} ");
        }
        Console.WriteLine();
    }
}
