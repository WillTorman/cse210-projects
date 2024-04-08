using System;

class Program
{
    static void Main(string[] args)
    {
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

        // Check if player 
        while (player.GetCurrentHealth() > 0)
        {
            string randomQuest = quest.GetRandomQuest();
            Console.WriteLine(randomQuest);
            // Display players HP
            player.DislayHp();

            // Game logic goes here...

            if (player.GetCurrentHealth() <= 0)
            {
                Console.WriteLine("GAME OVER!");
            }
        }
    }
}