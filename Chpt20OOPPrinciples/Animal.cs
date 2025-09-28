using System;

namespace Chpt20OOPPrinciples;

public abstract class Animal
{
    public void PrintInformation()
    {
        Console.WriteLine("I am a {0}.", this.GetType().Name);
        Console.WriteLine(GetTypicalSound());
    }

    protected abstract String GetTypicalSound();
}
