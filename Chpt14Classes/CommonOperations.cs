using System;

namespace Chpt14Classes;

public class CommonOperations<T>
{
    public void Swap<K>(ref T a, ref T b)
    {
        T oldA = a;
        a = b;
        b = oldA;
    }
}
