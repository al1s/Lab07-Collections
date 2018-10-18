using System;
using System.Collections.Generic;
using System.Linq;

namespace DeckOfCards.Classes
{
    public class Dealer
    {
        /// <summary>
        /// Inner storage for current game deck
        /// </summary>
        private Deck<Card> _deck = new Deck<Card>();
        /// <summary>
        /// Define how many card each hand could hold
        /// </summary>
        public int CardsInHand { get; set; } = 10;
        /// <summary>
        /// Start the game (initialize deck with available suits and ranks)
        /// </summary>
        public void Start()
        {
            List<Suit> SuitsAvailable = new List<Suit>();
            List<Rank> RanksAvailable = new List<Rank>();
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                SuitsAvailable.Add(suit);
            }
            foreach (Rank rank in (Rank[])Enum.GetValues(typeof(Rank)))
            {
                RanksAvailable.Add(rank);
            }
            var cardsToGenerate =
                 SuitsAvailable.SelectMany(suit => RanksAvailable,
                    (suit, rank) => new Card(suit, rank));
            foreach (var card in cardsToGenerate)
            {
                _deck.Add(card);
            }
        }
        /// <summary>
        /// Return how much cards in the deck
        /// </summary>
        /// <returns>number of cards in the deck</returns>
        public int GetNumberOfCardsInDeck() { return _deck.GetLength(); }
        /// <summary>
        /// Return all cards currently in the deck
        /// </summary>
        /// <returns>Array of cards</returns>
        public Card[] ShowDeckInGame()
        {
            return _deck.ToArray();
        }
        /// <summary>
        /// Distribute cards to hands
        /// </summary>
        /// <param name="h1">First hand</param>
        /// <param name="h2">First hand</param>
        public void Deal(Hand h1, Hand h2)
        {
            for (int i = 0; i < CardsInHand; i++)
            {
                h1.AddCard(_deck.GetCard());
                h2.AddCard(_deck.GetCard());
            }
        }
        /// <summary>
        /// Make dealer to withdraw all cards with a given suit from deck
        /// </summary>
        /// <param name="suit">Suit of cards to be withdrawn</param>
        /// <returns>Array of cards</returns>
        public Card[] GetAllCardWithSuit(Suit suit)
        {
            return _deck.ReturnSuit(suit);
        }
    }
}
