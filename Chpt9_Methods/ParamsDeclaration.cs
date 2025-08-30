using System;

namespace Chpt9_Methods;

// Prints many of arguments
public class ParamsDeclaration
{
    public static long CalcSum(params int[] elements)
    {
        long sum = 0;
        foreach (var element in elements)
        {
            sum += element;
        }
        return sum;
    }
}
