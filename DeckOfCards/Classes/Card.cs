using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Classes
{
    public enum Suit
    {
        Spade,
        Heart,
        Diamond,
        Club,
    }
    public enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        J,
        Q,
        K,
        A
    }
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString()
        {
            return $"{Suit} {Rank}";
        }
    }
}
