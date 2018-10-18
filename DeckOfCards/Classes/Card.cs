namespace DeckOfCards.Classes
{
    /// <summary>
    /// Card suit enumeration
    /// </summary>
    public enum Suit
    {
        Spade,
        Heart,
        Diamond,
        Club
    }
    /// <summary>
    /// Card rank enumeration
    /// </summary>
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
        /// <summary>
        /// Card suit
        /// </summary>
        public Suit Suit { get; set; }
        /// <summary>
        /// Card rank
        /// </summary>
        public Rank Rank { get; set; }
        /// <summary>
        /// Prepare card to be returned as a string 
        /// </summary>
        /// <returns>String with card's rank and suit</returns>
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
