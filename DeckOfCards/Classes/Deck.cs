using System;
using System.Collections;
using System.Collections.Generic;

namespace DeckOfCards.Classes
{
    public class Deck<T> : IEnumerable
    {
        /// <summary>
        /// Internal storage for our deck collection 
        /// </summary>
        private T[] _cards = new T[5];
        /// <summary>
        /// Actual length of the collection
        /// </summary>
        private int _cnt = 0;
        /// <summary>
        /// Add new element to the deck
        /// </summary>
        /// <param name="card">Card element to be added</param>
        public void Add(T card)
        {
            if (_cards.Length == _cnt)
            {
                T[] _temp = new T[_cnt * 2];
                for (int i = 0; i < _cnt; i++)
                {
                    _temp[i] = _cards[i];
                }
                _cards = _temp;
            }
            _cards[_cnt++] = card;
        }
        /// <summary>
        /// Remove element from collection
        /// </summary>
        /// <param name="card"></param>
        public void Remove(T card)
        {
            int indexOfCard = Array.IndexOf(_cards, card);
            if (indexOfCard != -1)
            {
                _cnt -= 1;
                Array.Copy(_cards, indexOfCard + 1, _cards, indexOfCard, _cnt - indexOfCard);
            }
        }
        /// <summary>
        /// Get the length of the collection
        /// </summary>
        /// <returns>Length of collection</returns>
        public int GetLength() { return _cnt; }
        /// <summary>
        /// Withdraw required suit from the deck
        /// </summary>
        /// <param name="suit">The suit to be removed</param>
        /// <returns>Array of Cards of the suit</returns>
        public Card[] ReturnSuit(Suit suit)
        {
            Deck<T> result = new Deck<T>();
            Deck<T> rangeToDelete = new Deck<T>();
            for (int i = 0; i < _cnt; i++)
            {
                if (((Card)(object)_cards[i]).GetSuit() == suit)
                {
                    result.Add(_cards[i]);
                    rangeToDelete.Add(_cards[i]);
                }
            }
            foreach (T item in rangeToDelete)
            {
                this.Remove(item);
            }
            return result.ToArray();
        }
        /// <summary>
        /// Convert collection to array
        /// </summary>
        /// <returns>Array of cards from the deck</returns>
        public Card[] ToArray()
        {
            Array.Resize<T>(ref _cards, _cnt);
            return Array.ConvertAll<T, Card>(_cards, elm => (Card)(object)elm);
        }
        /// <summary>
        /// Get pseudo-random card from the deck 
        /// </summary>
        /// <returns>Pseudo-random card</returns>
        public Card GetCard()
        {
            Random rnd = new Random();
            T result = _cards[rnd.Next(_cnt + 1)];
            this.Remove(result);
            return (Card)(object)result;
        }
        /// <summary>
        /// Foreach enabler (implementation of Enumerator)
        /// </summary>
        /// <returns>Enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _cnt; i++)
            {
                yield return _cards[i];
            }
        }
        /// <summary>
        /// Backward compatibility
        /// </summary>
        /// <returns>Enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
