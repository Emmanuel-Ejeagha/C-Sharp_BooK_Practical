using System;

namespace Chpt20OOPPrinciples;

public class OverrideExample
{
    public static void HowToOverride()
    {
        Console.WriteLine(new object());
        // Console.WriteLine(new Felidae(true));
        Console.WriteLine(new Lion(true, 80));
        Console.WriteLine(new AfricanLion(true, 50));
        Console.WriteLine("___-----____-----___----");

        AfricanLion africanLion = new AfricanLion(true, 90);
        string asAfricanLion = africanLion.ToString();
        string asObject = ((object)africanLion).ToString();
        Console.WriteLine(asAfricanLion);
        Console.WriteLine(asObject);
    }
}
