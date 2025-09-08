using System;

namespace Chpt14Classes;

public class Swapping
{
    public void Swap<K>(ref K a, ref K b)
    {
        K oldA = a;
        a = b;
        b = oldA;
    }
    public void PrintSwap()
    {

        int num1 = 3;
        int num2 = 5;

        Console.WriteLine("Before swap: {0} {1}", num1, num2);
        Swap(ref num1, ref num2);
        Console.WriteLine("After swap: {0} {1}", num1, num2);

        string str1 = "Hello";
        string str2 = "There";

        Console.WriteLine("Before swap: {0} {1}", str1, str2);
        Swap(ref str1, ref str2);
        Console.WriteLine("After swap: {0} {1}", str1, str2);

    }
}
