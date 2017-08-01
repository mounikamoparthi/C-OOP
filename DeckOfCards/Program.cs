using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card bill = new Card("bill","black",1);
            Console.WriteLine(bill.val);
            Deck bob = new Deck().Reset();
            Console.WriteLine(bob.cards.Count);
            Player joe = new Player("fghjkl");
            joe.Draw(bob);
            joe.discard(4);
        }
    }
}
