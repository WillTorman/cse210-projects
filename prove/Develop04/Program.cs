using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        bool loop = true;
        // Loop over options until 4 is selected.
        while (loop != false)
        {
            // Menu
            Console.WriteLine($"1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {

            }
            else if (answer == 2)
            {

            }
            else if (answer == 3)
            {

            }
            else
            {
                // This will break the loop if any other answer is chosen...
                loop = false;
            }
        }
    }
}