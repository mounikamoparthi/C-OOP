using System;

namespace human
{
   public class Program
    {
        public static void Main(string[] args)
        {
            // Human man = new Human("Bob");
            // Console.WriteLine("The name is "+man.name);
            Human player1 = new Human("Hero",40,8,16,500);
            Human player2 = new Human("Villian",40,10,16,700);
            player1.Attack(player2);
            Console.WriteLine($"After being attacked by the {player1.name}, the {player2.name}'s health is now {player2.health}");
        }
    }
}
