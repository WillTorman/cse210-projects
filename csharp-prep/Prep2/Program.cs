using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percentage = int.Parse(response);

        if (percentage >= 90)
        {
            Console.WriteLine("Your letter grade is an A!");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Your letter grade is a B!");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Your letter grade is a C.");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Your letter grade is a D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is a F");
        }
    }
}