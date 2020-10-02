using System;

namespace IslandAdventure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ISLAND ADVENTURE");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Picture this: you're in an airplane over open water...");
            Console.WriteLine("Suddenly the plane takes a dip! This is the last thing you remember until...");
            Console.WriteLine("You wake up... on a beach... on a small island... Alone.");
            Console.WriteLine();
            Console.WriteLine("Think YOU have what it takes to make it off the island?");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("The first thing you'll need to do is find some type of shelter!");
            Console.WriteLine();
            Console.WriteLine("You look around the island and realize you have 2 options...");
            Console.WriteLine();
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
                Console.WriteLine();
                Console.WriteLine("Uh oh! It looks like the cave you found was already home to a wild animal!");
                Console.WriteLine("It attacked you!");
                Console.WriteLine("You won't make it off the island because you're dead!");
                Console.WriteLine();
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                Console.WriteLine("Better luck next time!");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                Environment.Exit(0);
                
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("After working all day building your new hut, you fall asleep fast.");
                Console.WriteLine("You wake up the next day feeling well rested and HUNGRY!");
                Console.WriteLine();
                Console.WriteLine("You remember the wild berries you saw the day before...");
                Console.WriteLine("They looked SO good, but you aren't sure if they're safe to eat.");
                Console.WriteLine();
                Console.WriteLine("You could try fishing instead..."); 
                Console.WriteLine("you pick up the crude knife you made while building your hut..."); 
                Console.WriteLine("but would fishing like this be too hard?");
                Console.WriteLine("........................................");
                Console.WriteLine("Type 'a' if you would like to risk your luck and eat the wild berries");
                Console.WriteLine("or 'b' to try your hand at fishing with your homemade knife:");
                input = Console.ReadLine();
                if (input == "a")
                {
                    Console.WriteLine();
                    Console.WriteLine("Oh no! Seems you were right to be worried.");
                    Console.WriteLine("The berries you found were poison berries!");
                    Console.WriteLine("You won't make it off the island because you're dead.");
                    Console.WriteLine();
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                    Console.WriteLine("Better luck next time!");
                    Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                    Environment.Exit(0);   
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("It was tricky to catch the fish, but you did it!");
                    Console.WriteLine("It was such a feast and you've never tasted fish so delicious in your life!");
                    Console.WriteLine();
                    Console.WriteLine("After eating,");
                    Console.WriteLine("you look around the island and realize you have to find a way home.");
                    Console.WriteLine("But how??");
                    Console.WriteLine();
                    Console.WriteLine("As you're looking around, you find all the supplies you'd need to get home.");
                    Console.WriteLine("The question is... ");
                    Console.WriteLine("What will you choose to create?");
                    Console.WriteLine();
                    Console.WriteLine("You could build a boat... ");
                    Console.WriteLine("but even if you get it to float,");
                    Console.WriteLine("there's still a big chance that you would drift at sea forever.");
                    Console.WriteLine();
                    Console.WriteLine("Should you play it safe instead?");
                    Console.WriteLine("You could build an S.O.S. sign on the beach...");
                    Console.WriteLine("big enough for a passing plane to see!");
                    Console.WriteLine("......................................");
                    Console.WriteLine("Type 'a' if you would like to build a raft or 'b' to build an S.O.S. sign:");
                    input = Console.ReadLine();
                    if (input == "a")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your boat came together pretty quickly and honeslty doesn't look half bad,");
                        Console.WriteLine("but you didn't think about how long it could stay afloat.");
                        Console.WriteLine();
                        Console.WriteLine("You push past the waves and finally make it out to open waters...");
                        Console.WriteLine("where your boat starts taking in water!");
                        Console.WriteLine("When your boat finally sinks it takes you down with it and you drown.");
                        Console.WriteLine("You may have made it off the island... but you'll never make it home.");
                        Console.WriteLine();
                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                        Console.WriteLine("Better luck next time!");
                        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
                        Environment.Exit(0);                  
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("The S.O.S. is huge and it looks great on the beach!");
                        Console.WriteLine();
                        Console.WriteLine("The pilot of a passing plane is able to see it and she notifies the right people right away!");
                        Console.WriteLine("You wake up one morning to noise on the beach.");
                        Console.WriteLine("It's in that very moment that you realize you're not all alone anymore,");
                        Console.WriteLine("but even better than that...");
                        Console.WriteLine();
                        Console.WriteLine("YOU'RE GOING HOME!");
                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("Congratulations!! You've made it off the island!!");
                        Console.WriteLine("*************************************************");
                    }
                }
            }
        }   
    }
}
