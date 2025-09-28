using System;

namespace Chpt20OOPPrinciples;

public class AfricanLion : Lion
{
    public AfricanLion(bool male, int weight) : base(male, weight)
    {

    }

    public new string ToString()
    {
        return string.Format(
            "(AfricanLion, male: {0}, weight: {1})", this.Male, this.Weight
        );
    }

    public override void CatchPrey(object prey)
    {
        Console.WriteLine("AfricanLion.CatchPrey");
        Console.WriteLine("calling base.CatchPrey");
        Console.Write("\t");
        base.CatchPrey(prey);
        Console.WriteLine("...end of call.");

    }


}
