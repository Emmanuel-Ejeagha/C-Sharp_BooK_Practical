using System;

namespace Chpt20OOPPrinciples;

public class Country
{
    /// <summary>Country's capital - association</summary>
    private Capital capital;


    public Capital Capital
    {
        get { return capital; }
        set { this.capital = value; }
    }
}
