using System;

namespace Chpt21HighQualityProgrammingCode;

public class UnitTest
{
    public static long Sum(int[] numbers)
    {
        long sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}

