using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the list
        List<int> numbers = new List<int>();
        int answer;

        do
        {
            Console.Write("Enter a number (type 0 when finished): ");

            // Parse the user input to an integer
            if (int.TryParse(Console.ReadLine(), out answer))
            {
                if (answer != 0)
                {
                    numbers.Add(answer);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (answer != 0);

        // Check if the list is not empty
        if (numbers.Count > 0)
        {
            int sum = 0;

            // Calculate the sum
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}");

            // Find the average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find the max
            int max = numbers[0];

            // Iterate to find the maximum number
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"The max is: {max}");
        }
        else
        {
            Console.WriteLine("The list is empty.");
        }
    }
}
