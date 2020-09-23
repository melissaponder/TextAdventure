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
            Choice();
        }
        static void Choice()
        {
            string input = "";
            Console.WriteLine("Type 'A' if you would like to build a hut or 'B' to find a cave:");
            input = Console.ReadLine();
            if (input == "B")
            {
                Console.WriteLine("Uh oh! Looks like the cave you found was already home to a wild animal and it attacked you! You won't make it off the island because you're dead!");
            }
        }



    }
            
      
}
