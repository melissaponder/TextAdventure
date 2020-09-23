using System;

namespace IslandAdventure
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ISLAND ADVENTURE");
            Console.WriteLine("Think you have what it takes to make it off the island?");
            Console.WriteLine("First you need to find a shelter!");
            Console.WriteLine("It looks like you have 2 options...");
            Console.WriteLine("You can either build your own hut or journey into the jungle and find a cave.");
            Choice1();
            Choice2();
            

        }
        static void Choice1()
        {
            string input = "";
            Console.WriteLine("Type 'a' if you would like to build a hut or 'b' to find a cave:");
            input = Console.ReadLine();
            if (input == "b")
            {
                Console.WriteLine("Uh oh! Looks like the cave you found was already home to a wild animal and it attacked you! You won't make it off the island because you're dead!");
            }
            else
            {
                Console.WriteLine("You've had a great night of rest, but you're getting pretty hungry!");
                Console.WriteLine("You can either head into the forest to look for berries or find supplies and craft a spear to hunt for fish and game.");
            }
        }

        public static void Choice2()
        {
            string input = "";
            Console.WriteLine("Type 'a' if you would like to look for berries or 'b' to craft a spear and hunt:");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.WriteLine("Oh no! The berries you found were poison berries! You won't make it off the island because you're dead.");
            }
            else
            {
                Console.WriteLine("It was tricky to catch the fish, but you did it!");
                Console.WriteLine("I think it's about time to look for a way off this island!");
                Console.WriteLine("You can either try to build your own raft or you can build a large S.O.S. sign on the beach.");
            }
        }
    }
}