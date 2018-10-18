namespace DeckOfCards.Classes
{
    public class Hand
    {
        /// <summary>
        /// Internal storage for cards
        /// </summary>
        private Deck<Card> _deck = new Deck<Card>();
        /// <summary>
        /// Internal length of the deck on the hand
        /// </summary>
        private int _cnt = 0;
        /// <summary>
        /// Add card into the deck on the hand
        /// </summary>
        /// <param name="card">Card to be added</param>
        public void AddCard(Card card)
        {
            _deck.Add(card);
            _cnt += 1;
        }
        /// <summary>
        /// Get the length of the deck
        /// </summary>
        /// <returns>The length of the deck</returns>
        public int GetDeckLength() { return _cnt; }
        /// <summary>
        /// Get all cards on the hand
        /// </summary>
        /// <returns>Array of cards</returns>
        public Card[] OpenHand()
        {
            return _deck.ToArray();
        }
    }
}
