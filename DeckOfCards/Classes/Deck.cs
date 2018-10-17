using System;
using System.Collections;
using System.Collections.Generic;

namespace DeckOfCards.Classes
{
    public class Deck<T> : IEnumerable
    {
        private T[] _cards = new T[5];
        private int _cnt = 0;
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
        public void Remove(T card)
        {
            int indexOfCard = Array.IndexOf(_cards, card);
            if (indexOfCard != -1)
            {
                _cnt -= 1;
                Array.Copy(_cards, indexOfCard + 1, _cards, indexOfCard, _cnt - indexOfCard);
            }
        }
        public int GetLength() { return _cnt; }
        public Card[] ReturnSuit(Suit suit)
        {
            Deck<T> result = new Deck<T>();
            Deck<T> rangeToDelete = new Deck<T>();
            for (int i = 0; i < _cnt; i++)
            {
                if (((Card)(object)_cards[i]).Suit == suit)
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
        public Card[] ToArray()
        {
            Array.Resize<T>(ref _cards, _cnt);
            return Array.ConvertAll<T, Card>(_cards, elm => (Card)(object)elm);
        }
        public Card GetCard()
        {
            Random rnd = new Random();
            T result = _cards[rnd.Next(_cnt + 1)];
            this.Remove(result);
            return (Card)(object)result;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _cnt; i++)
            {
                yield return _cards[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
