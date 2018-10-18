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
        private Suit _Suit { get; set; }
        /// <summary>
        /// Card rank
        /// </summary>
        private Rank _Rank { get; set; }
        /// <summary>
        /// Prepare card to be returned as a string 
        /// </summary>
        /// <returns>String with card's rank and suit</returns>
        public override string ToString()
        {
            if (_Rank == Rank.Jack ||
                _Rank == Rank.Queen ||
                _Rank == Rank.King ||
                _Rank == Rank.Ace)
            {
                return $"{_Rank} {_Suit}";
            }

            return $"{(int)_Rank} {_Suit}";
        }
        public Suit GetSuit() { return _Suit; }
        public Rank GetRank() { return _Rank; }
        public Card(Suit suit, Rank rank)
        {
            _Suit = suit;
            _Rank = rank;
        }
    }
}
