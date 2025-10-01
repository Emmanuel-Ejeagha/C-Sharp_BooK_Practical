using System;

namespace Chpt23MethodologyOfProblemSolving;

public class CardShuffles
{
    static Random rand = new Random();
    static List<Card> cards = new List<Card>();
    public static void CreateCardShuffle()
    {
        cards.Add(new Card() { Face = "7", Suit = Suit.HEART });
        cards.Add(new Card() { Face = "A", Suit = Suit.SPADE });
        cards.Add(new Card() { Face = "10", Suit = Suit.DIAMOND });
        cards.Add(new Card() { Face = "2", Suit = Suit.CLUB });
        cards.Add(new Card() { Face = "6", Suit = Suit.DIAMOND });
        cards.Add(new Card() { Face = "J", Suit = Suit.CLUB });

        Console.Write("Initial deck: ");
        PrintCards(cards);

        ShuffleCards(cards);
        Console.Write("After shuffle: ");
        PrintCards(cards);

        Console.Write("Test Shuffle 52 Cards: ");
        TestShuffle52Cards();
    }

    static void TestShuffle52Cards()
    {
        string[] allFaces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K", "A" };
        Suit[] allSuits = new Suit[] { Suit.CLUB, Suit.DIAMOND, Suit.HEART, Suit.SPADE };
        foreach (string face in allFaces)
        {
            foreach (Suit suit in allSuits)
            {
                Card card = new Card() { Face = face, Suit = suit };
                cards.Add(card);
            }
        }
        ShuffleCards(cards);
        PrintCards(cards);
    }

    static void PerformSingleSwap(List<Card> cards, int index)
    {
        int randomIndex = rand.Next(1, cards.Count);
        Card firstCard = cards[index];
        Card randomCard = cards[randomIndex];
        cards[index] = randomCard;
        cards[randomIndex] = firstCard;
    }

    static void ShuffleCards(List<Card> cards)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            PerformSingleSwap(cards, i);
            // PrintCards(cards);
        }
    }

    static void PrintCards(List<Card> cards)
    {
        foreach (Card card in cards)
        {
            Console.Write(card);
        }
        Console.WriteLine();
    }
}
