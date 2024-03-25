using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Will", 20, 20, 5, 3);

        bool loop = true;

        while (loop != false)
        {
            // Menu
            Console.WriteLine($"\nWhat player type would you like to be?\n");
            Console.WriteLine($"Player Types:\n    1. Wizard (Magic)\n    2. Warrior (Melee)\n    3. Marksman (Ranged)    6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            int choice = int.Parse(Console.ReadLine());

            // Create new goal
            if (choice == 1)
            {
                
            }

            else if (choice == 2)
            {
                
            }

            else if (choice == 3)
            {

            }
            // Exit program
            else
            {
                // This will break the loop if 6 or any other answer is chosen...
                loop = false;
            }
        }
    }
}