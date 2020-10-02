using System;

namespace IslandAdventure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ISLAND ADVENTURE");
            Console.WriteLine("----------------");
            Console.WriteLine("Think YOU have what it takes to make it off the island?");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("First you need to find some type of shelter!");
            Console.WriteLine("It looks like you have 2 options...");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("You can either build your own hut or journey into the jungle and find a cave.");
            Console.WriteLine(".............................................................................");
            Choice1();
        }

        public static void Choice1()
        {
            string input = "";
            Console.WriteLine("Type 'a' if you would like to build a hut or 'b' to find a cave:");
            input = Console.ReadLine();
            if (input == "b")
            {
                Console.WriteLine("Uh oh! Looks like the cave you found was already home to a wild animal!");
                Console.WriteLine("It attacked you!");
                Console.WriteLine("You won't make it off the island because you're dead!");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Better luck next time!");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                Environment.Exit(0);
                
            }
            else
            {
                Console.WriteLine("You've had a great night of rest, but you're getting pretty hungry!");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You can either head into the forest to look for berries...");
                Console.WriteLine("OR you can find supplies and craft a spear to hunt for fish and game.");
                Console.WriteLine(".....................................................................");
                Console.WriteLine("Type 'a' if you would like to look for berries or 'b' to craft a spear and hunt:");
                input = Console.ReadLine();
                if (input == "a")
                {
                    Console.WriteLine("Oh no! The berries you found were poison berries!");
                    Console.WriteLine("You won't make it off the island because you're dead.");
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Better luck next time!");
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                    Environment.Exit(0);   
                }
                else
                {
                    Console.WriteLine("It was tricky to catch the fish, but you did it!");
                    Console.WriteLine("I think it's about time to look for a way off this island!");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("You can either try to build your own raft...");
                    Console.WriteLine("or you can build a large S.O.S. sign on the beach.");
                    Console.WriteLine("..................................................");
                    Console.WriteLine("Type 'a' if you would like to build a raft or 'b' to build an S.O.S. sign:");
                    input = Console.ReadLine();
                    if (input == "a")
                    {
                        Console.WriteLine("Your boat came together pretty quickly,");
                        Console.WriteLine("but you didn't think about how long it would stay afloat!");
                        Console.WriteLine("You make it to open waters and your boat sinks. You're dead.");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                        Environment.Exit(0);                  
                    }
                    else
                    {
                        Console.WriteLine("The sticks and leaves you found look great on the beach!");
                        Console.WriteLine("A passing plane sees your S.O.S. and saves you!");
                        Console.WriteLine("***********************************************");
                        Console.WriteLine("Congratulations you've made it off the island!!");
                        Console.WriteLine("***********************************************");
                    }
                }
            }
        }   
    }
}
