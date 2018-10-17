using System;
using System.Collections.Generic;
using System.Text;
using DeckOfCards.Classes;

namespace DeckOfCards.Classes
{
    public class Hand
    {
        Deck<Card> _deck = default(Deck<Card>);
        public Hand(Deck<Card> deck)
        {
            _deck = deck;
        }
        public Card[] OpenHand()
        {
            return _deck.ToArray();
        }
    }
}
