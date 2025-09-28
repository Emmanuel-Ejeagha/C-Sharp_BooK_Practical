using System;

namespace Chpt20OOPPrinciples;

public abstract class Felidae
{
    private bool male;

    //  This constructor calls another constructor
    public Felidae() : this(true)
    { }

    // This is the constructor that is inherited
    public Felidae(bool male)
    {
        this.male = male;
    }

    public bool Male
    {
        get { return male; }
        set { this.male = value; }
    }

    public virtual void Walk()
    {

    }

    protected void Hide()
    {

    }

    protected void Run()
    {

    }

    public abstract void CatchPrey(object prey);
}
