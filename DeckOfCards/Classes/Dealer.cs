﻿using System;
using System.Collections.Generic;
using System.Linq;
using DeckOfCards.Classes;

namespace DeckOfCards.Classes
{
    public class Dealer
    {
        Deck<Card> _deck = new Deck<Card>();
        public void Start()
        {
            List<Suit> SuitsAvailable = new List<Suit>();
            List<Rank> RanksAvailable = new List<Rank>();
            foreach (Suit suit in (Suit[]) Enum.GetValues(typeof(Suit)))
            {
                SuitsAvailable.Add(suit);
            }
            foreach (Rank rank in (Rank[]) Enum.GetValues(typeof(Rank)))
            {
                RanksAvailable.Add(rank);
            }
            var cardsToGenerate =
                 SuitsAvailable.SelectMany(suit => RanksAvailable, 
                    (suit, rank) => new Card { Suit = suit, Rank = rank });
            foreach (var card in cardsToGenerate)
            {
                _deck.Add(card);
            }
        }
        public int GetNumberOfCardsInDeck() { return _deck.GetLength(); }
        public Card[] ShowDeckInGame()
        {
            return _deck.ToArray();
        }
        public void Deal(Hand h1, Hand h2)
        {
            _deck.GetCard();
        }
    }
}
