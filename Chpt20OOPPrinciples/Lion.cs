using System;

namespace Chpt20OOPPrinciples;

public class Lion : Felidae, Reproducible<Lion>
{
    private int weight;
    private Paw frontLeft;
    private Paw frontRight;
    private Paw bottomLeft;
    private Paw bottomRight;

    // Keyword "base" will be explained in the next paragraph
    public Lion(bool male, int weight) : base(male)
    {
        this.weight = weight;
    }

    public int Weight
    {
        get { return weight; }
        set { this.weight = value; }
    }

    private void MovePaw(Paw paw)
    {

    }

    public class Paw
    {

    }
    public override void Walk()
    {
        this.MovePaw(frontLeft);
        this.MovePaw(frontRight);
        this.MovePaw(bottomLeft);
        this.MovePaw(bottomRight);
    }

    protected void Ambush()
    {

    }

    // public override bool CatchPrey(object prey)
    // {
    //     base.Hide();
    //     this.Ambush();
    //     base.Run();

    //     Console.WriteLine("Lion.CatchPrey");
    //     return false;
    // }
    public override void CatchPrey(object prey)
    {
        Console.WriteLine("Lion.CatchPrey");
    }

    Lion[] Reproducible<Lion>.Reproduce(Lion mate)
    {
        return new Lion[] { new Lion(true, 12), new Lion(false, 10) };
    }



}
