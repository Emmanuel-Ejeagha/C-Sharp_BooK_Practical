using System;

namespace Chpt20OOPPrinciples;

public class ObjectExample
{
    public static void RunObjectExample()
    {
        AfricanLion africanLion = new AfricanLion(true, 80);
        // Implicit casting
        object obj = africanLion;

        try
        {
            // Explicit casting
            AfricanLion castedLion = (AfricanLion)obj;
        }
        catch (InvalidCastException ice)
        {

            Console.WriteLine("obj cannot be downcasted to AfricanLion");
        }
    }
}
