using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> quests = new List<string> { "It takes you four hours to hike a mountain. You got hurt along the way and lose -2 HEALTH; however, at the top is a dragon egg. You eat it and gain +5 HEALTH (+3 total)", "A goblin army sent a scout to find you. He intends to fight, because you have spotted him. Will you 1. FIGHT or 2. RUN? [Input #]" };
        
        Console.WriteLine("What would you like to name your character? ");
        string uName = Console.ReadLine();
        Player player = null;
        // Enemy enemy;
        Quest quest = new Quest();

        // Menu & Intro
        Console.Clear();
        Console.WriteLine($"{uName}, welcome to the war! We have heard of your bravery and courage. And we will be needing your help to end this war!");
        Console.WriteLine("\nWhat faction would you like to join?\n");
        Console.WriteLine("Factions:");
        Console.WriteLine("\t1. Wizard (Magic): [15 Health, 3 Attack, 3 Defense]");
        Console.WriteLine("\t2. Warrior (Melee): [15 Health, 5 Attack, 2 Defense]");
        Console.WriteLine("\t3. Assassin (Stealth): [10 Health, 7 Attack, 1 Defense]");
        Console.WriteLine("\t4. Quit Game");
        Console.WriteLine("Select a faction from the menu:");
        int choice = int.Parse(Console.ReadLine());

        // Player faction input
        if (choice == 1)
        {
            player = new Wizard();
        }

        else if (choice == 2)
        {
            //player = new Warrior();
        }

        else if (choice == 3)
        {
            //player = new Assassin();
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
            return; // Exit program if the player chooses to quit
        }

        // Check if player is alive
        while (player.GetCurrentHealth() > 0)
        {
            player.DislayHp();
            string randomQuest = quest.GetRandomQuest();
            Console.WriteLine(randomQuest);
            // Display players HP

            // Game logic goes here...
            Console.WriteLine("You are a brave warrior in the kingdom of Zork. You are standing in front of the castle gate. The evil dragon has captured the princess.");
            Console.Write("Do you FIGHT the dragon or CALL for help? ");
            string actOne = Console.ReadLine().ToLower();

            if (actOne == "fight")
            {
                Console.WriteLine("You draw your sword and charge at the dragon.");
                Console.Write("Do you aim for the dragon's HEAD or TAIL? ");
                string actTwo = Console.ReadLine().ToLower();

                if (actTwo == "head")
                {
                    Console.WriteLine("You swing your sword at the dragon's head. The dragon breathes fire and you are burned to a crisp.");
                    Console.WriteLine("GAME OVER");
                }
                else if (actTwo == "tail")
                {
                    Console.WriteLine("You swing your sword at the dragon's tail. The dragon is caught off guard and you manage to slay it.");
                    Console.WriteLine("Congratulations! You have saved the princess and won the game!");
                }
                else
                {
                    Console.WriteLine("GAME OVER: THAT WAS NOT AN OPTION");
                }
            }
            else if (actOne == "call")
            {
                Console.WriteLine("You call for help. The king's knights come to your aid.");
                Console.Write("Do you CHARGE with the knights or HOLD back? ");
                string actTwo = Console.ReadLine().ToLower();

                if (actTwo == "charge")
                {
                    Console.WriteLine("You charge with the knights. The dragon is overwhelmed and is defeated.");
                    Console.WriteLine("Congratulations! You have saved the princess and won the game!");
                }
                else if (actTwo == "hold")
                {
                    Console.WriteLine("You hold back and let the knights fight. The knights are defeated and the dragon turns its attention to you.");
                    Console.WriteLine("GAME OVER");
                }
                else
                {
                    Console.WriteLine("GAME OVER: THAT WAS NOT AN OPTION");
                }
            }
            else
            {
                Console.WriteLine("GAME OVER: THAT WAS NOT AN OPTION");
            }
    

            if (player.GetCurrentHealth() <= 0)
            {
                Console.WriteLine("GAME OVER!");
            }
        }
    }
}