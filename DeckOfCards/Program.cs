using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card bill = new Card("bill","black",1);
            Console.WriteLine(bill.val+ bill.suit);
            Deck bob = new Deck().reset();
            //Console.WriteLine(bob.cards.Count);
            Player joe = new Player("fghjkl");
            joe.draw(bob,5);
            System.Console.WriteLine(joe.hand.Count);
            joe.discard(4);
            System.Console.WriteLine(joe.hand.Count);
        }
    }
}
