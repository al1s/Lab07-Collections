using System;
using System.Collections;
using System.Collections.Generic;
using DeckOfCards.Classes;

namespace DeckOfCards.Classes
{
    public class Deck<T> : IEnumerable
    {
        private T[] _cards = new T[5];
        private int _cnt = 0;
        public void Add(T card)
        {
            if(_cards.Length == _cnt)
            {
                T[] _temp = new T[_cnt * 2];
                for (int i = 0; i < _cnt; i++)
                {
                    _temp[i] = _cards[i];
                }
                _cards = _temp;
                _cards[_cnt++] = card;
            }
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
        public Card[] ReturnSuit(Suit suit)
        {
            Deck<T> result = new Deck<T>();
            for (int i=0; i < _cnt; i++)
            {
                if(((Card)(object)_cards[i]).Suit == suit)
                {
                    result.Add(_cards[i]);
                    this.Remove(_cards[i]);
                }
            }
            return result.ToArray();
        }
        public Card[] ToArray()
        {
            return Array.ConvertAll<T, Card>(_cards, elm => (Card)(object)elm);
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
