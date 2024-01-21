using System;

class Program
{
    static void Main(string[] args)
    {
        // do-while loop
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 100);
        int guess;
        do
        {
            // ask for a user guess
            System.Console.WriteLine($"What is your guess? [BETWEEN 1-100]");
            guess = int.Parse(Console.ReadLine());

            // check if guess is high
            if (guess > random)
            {
                System.Console.WriteLine($"Too High");
            }

            // check if guess is low
            else if (guess < random)
            {
                System.Console.WriteLine($"Too Low");
            }

            // Check if guess is match
            else
            {
                System.Console.WriteLine("Correct");
            }
        } while (random != guess);
    }
}