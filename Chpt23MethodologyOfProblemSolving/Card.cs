using System;

namespace Chpt23MethodologyOfProblemSolving;

public class Card
{
    public string Face { get; set; } = string.Empty;
    public Suit Suit { get; set; }

    public override string ToString()
    {
        string card = "(" + this.Face + " " + this.Suit + ")";
        return card;
    }

}
public enum Suit
{
    CLUB, DIAMOND, HEART, SPADE
}
