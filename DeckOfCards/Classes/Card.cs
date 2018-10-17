namespace DeckOfCards.Classes
{
    public enum Suit
    {
        Spade,
        Heart,
        Diamond,
        Club
    }
    public enum Rank
    {
        Six = 6,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
        public override string ToString()
        {
            if (Rank == Rank.Jack ||
                Rank == Rank.Queen ||
                Rank == Rank.King ||
                Rank == Rank.Ace)
            {
                return $"{Rank} {Suit}";
            }

            return $"{(int)Rank} {Suit}";
        }
    }
}
