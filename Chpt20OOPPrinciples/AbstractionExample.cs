using System;

namespace Chpt20OOPPrinciples;

public class AbstractionExample
{
    public static void AsAbstractionExample()
    {

        Lion lion = new Lion(true, 30);
        Felidae bigCat1 = lion;

        AfricanLion africanLion = new AfricanLion(true, 50);
        Felidae bigCat2 = africanLion;

    }
}
