using System;

namespace Chpt20OOPPrinciples;

public class TransitivityExample
{
    public static void TransitiveExample()
    {
        AfricanLion africanLion = new AfricanLion(true, 14);
        // Property defined in Felidae
        bool male = africanLion.Male;
        africanLion.Male = true;
    }
}
