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
            Console.WriteLine("Cards in the deck:".ToUpper());
            Console.WriteLine(dealer.GetNumberOfCardsInDeck().ToString());
            Console.WriteLine();
            Console.WriteLine("Available cards:".ToUpper());
            Console.WriteLine(string.Join<Card>(", ", dealer.ShowDeckInGame()));
            Console.WriteLine();
            Console.WriteLine("Let's get rid of Clubs. Here they are:".ToUpper());
            Console.WriteLine(string.Join<Card>(", ", dealer.GetAllSuitFromDeck(Suit.Club)));
            Console.WriteLine();
            Console.WriteLine("Available cards:".ToUpper());
            Console.WriteLine(string.Join<Card>(", ", dealer.ShowDeckInGame()));
            Hand hand1 = new Hand();
            Hand hand2 = new Hand();
            Console.WriteLine();
            Console.WriteLine("Lets ask dealer to deal".ToUpper());
            dealer.Deal(hand1, hand2);
            Console.WriteLine("What we have on the first hand:".ToUpper());
            Console.WriteLine(string.Join<Card>(", ", hand1.OpenHand()));
            Console.WriteLine();
            Console.WriteLine("What we have on the second hand:".ToUpper());
            Console.WriteLine(string.Join<Card>(", ", hand2.OpenHand()));
            Console.WriteLine();
            Console.WriteLine("Dealer has:".ToUpper());
            Console.WriteLine(string.Join<Card>(", ", dealer.ShowDeckInGame()));
            Console.WriteLine();
            Console.WriteLine("Cards in the dealer's deck:".ToUpper());
            Console.WriteLine(dealer.GetNumberOfCardsInDeck().ToString());
            Console.WriteLine("Cards on the first hand deck:".ToUpper());
            Console.WriteLine(hand1.GetDeckLength().ToString());
            Console.WriteLine("Cards on the second hand deck:".ToUpper());
            Console.WriteLine(hand2.GetDeckLength().ToString());
            Console.ReadLine();
        }
    }
}
