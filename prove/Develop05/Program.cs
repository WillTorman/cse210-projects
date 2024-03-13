using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        var points = 0;
        bool loop = true;

        while (loop != false)
        {
            // Menu
            Console.WriteLine($"You have {points}.");
            Console.WriteLine($"Menu Options:\n    1. Create New Goal\n    2. List Goals\n   3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                Console.WriteLine("\nThe types of goals are:\n    1. Simple Goal\n    2. Eternal Goal\n   3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());
                // Option 1 choices
                // Simple Goal
                if (goalType == 1)
                {
                    var simple = new Simple();
                    goals.Add(simple);
                }
                // Eternal Goal
                else if (goalType == 2)
                {

                }
                // All other input will equivelant to 3
                // Checklist goal
                else
                {

                }
            }
            else if (answer == 2)
            {
                Console.WriteLine("The goals are: ");
                // For loop to display all entries in list
                foreach (Goal goal in goals)
                {
                    goal.Display();
                }
            }
            else if (answer == 3)
            {

            }
            else if (answer == 4)
            {

            }
            else if (answer == 5)
            {

            }
            else
            {
                // This will break the loop if 6 or any other answer is chosen...
                loop = false;
            }
        }
    }
}