using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck bob = new Deck().Reset();
            Console.WriteLine(bob.cards.Count);
        }
    }
}
