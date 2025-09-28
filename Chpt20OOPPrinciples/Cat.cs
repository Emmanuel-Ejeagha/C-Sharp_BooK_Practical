using System;

namespace Chpt20OOPPrinciples;

public class Cat : Animal
{
    protected override String GetTypicalSound()
    {
        return "Meoooow!";
    }
}
