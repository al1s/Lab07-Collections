using System;
using Xunit;
using DeckOfCards.Classes;

namespace DeckOfCardsTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test whether we can add a card to a deck
        /// </summary>
        [Fact]
        public void CadAddCard()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card = new Card(Suit.Club, Rank.Ace);
            deck.Add(card);
            Assert.Equal(card, deck.ReturnSuit(Suit.Club)[0]);
        }
        /// <summary>
        /// Test whether we can set/get suit for a card
        /// </summary>
        [Fact]
        public void CanGetSetSuit()
        {
            Card card = new Card(Suit.Club, Rank.Ace);
            Assert.Equal(Suit.Club, card.GetSuit());
        }
        /// <summary>
        /// Test whether we can set/get rank for a card
        /// </summary>
        [Fact]
        public void CanGetSetRank()
        {
            Card card = new Card(Suit.Club, Rank.Ace);
            Assert.Equal(Rank.Ace, card.GetRank());
        }
        /// <summary>
        /// Test whether we can remove an existing card from a deck
        /// </summary>
        [Fact]
        public void CanRemoveExistingCard()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card = new Card(Suit.Club, Rank.Ace);
            deck.Add(card);
            deck.Remove(card);
            Assert.Equal(new Deck<Card>(), deck);
        }
        /// <summary>
        /// Test whether we can't remove an non-existing card from a deck
        /// </summary>
        [Fact]
        public void CantRemoveNonExistingCard()
        {
            Deck<Card> deck = new Deck<Card>();
            Card cardAce = new Card(Suit.Club, Rank.Ace);
            Card cardKing = new Card(Suit.Club, Rank.King);
            deck.Add(cardAce);
            deck.Remove(cardKing);
            Assert.Equal(cardAce, deck.ReturnSuit(Suit.Club)[0]);
            Assert.Equal(new Deck<Card>(), deck);
        }
    }
}
