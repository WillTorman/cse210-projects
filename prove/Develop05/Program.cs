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
            Console.WriteLine($"\nYou have {points} points.\n");
            Console.WriteLine($"Menu Options:\n    1. Create New Goal\n    2. List Goals\n    3. Save Goals\n    4. Load Goals\n    5. Record Event\n    6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            int answer = int.Parse(Console.ReadLine());

            // Create new goal
            if (answer == 1)
            {
                Console.WriteLine("\nThe types of goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());
                // Option 1 choices
                // Simple Goal
                if (goalType == 1)
                {
                    var simp1 = new Simple();
                    goals.Add(simp1);
                }
                // Eternal Goal
                else if (goalType == 2)
                {
                    var eternal1 = new Eternal();
                    goals.Add(eternal1);
                }
                // All other input will equivelant to 3
                // Checklist goal
                else
                {
                    var cl1 = new Checklist();
                    goals.Add(cl1);
                }
            }
            // List Goals
            else if (answer == 2)
            {
                Console.WriteLine("The goals are: ");
                // For loop to display all entries in list
                for (int i = 0; i < goals.Count; i++)
                {
                    goals[i].Display(i + 1); // Pass the index (i + 1 because indices start at 0) to the Display method

                    if (goals[i] is Checklist checklist)
                    {
                        Console.Write(checklist.GetCurrentProgress());
                    }
                }
            }
            // Save goals to file
            else if (answer == 3)
            {

            }
            // Load goals from a file
            else if (answer == 4)
            {

            }
            // Record/check event
            else if (answer == 5)
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