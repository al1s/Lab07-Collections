using System;
using DeckOfCards.Classes;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();
            dealer.Start();
            Console.WriteLine(dealer.GetNumberOfCardsInDeck().ToString());
            Console.WriteLine(string.Join<Card>(Environment.NewLine, dealer.ShowDeckInGame()));
            Console.ReadLine();
        }
    }
}
