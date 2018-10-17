namespace DeckOfCards.Classes
{
    public class Hand
    {
        private Deck<Card> _deck = new Deck<Card>();
        private int _cnt = 0;
        public Hand() { }
        public Hand(Deck<Card> deck)
        {
            _deck = deck;
            _cnt = deck.GetLength();
        }
        public void AddCard(Card card)
        {
            _deck.Add(card);
            _cnt += 1;
        }
        public int GetDeckLength() { return _cnt; }
        public Card[] OpenHand()
        {
            return _deck.ToArray();
        }
    }
}
