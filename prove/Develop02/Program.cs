using System;
using System.ComponentModel.Design;

class Program
{
    // This is a field that stores the journal object
    public Journal journal;

    // This is the main method that runs the program
    static void Main(string[] args)
    {
        // Create a new journal object
        journal = new Journal();
        // Call the Run method to start the program logic
        Run();
    }

    // This is a method that runs the program logic
    public void Run()
    {
        // Create a new journal object
        journal = new Journal();

        // Create a boolean variable to control the loop
        bool keepGoing = true;
        // Start a loop that runs until the user wants to exit
        while (keepGoing)
        {
            // Call the ShowsMenu method to display the options and get the user's selection
            var selection = ShowsMenu();

            // If the user selects 1, add a new entry to the journal
            if (Selection == 1)
            {
                // propmpt user with a random prompt
                // read in user input

                // Create a new entry object with the response and the prompt
                var entry = new Entry(response, prompt);
                // Call the AddEntry method of the journal object to add the entry to the journal
                journal.AddEntry(entry);
            }
            // If the user selects 2, display the journal entries
            else if (selection == 2)
            {
                // display entries
            }
            // Break loop by setting variable to false
            else if (selection == 3)
            {
                keepGoing = false;
            }
        }
    }

    static void ShowsMenu()
    {
        Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entry \n 3. Exit");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    public void SaveToFile()
    {
        // TODO: Implement the logic to save the journal entries to a file
    }

    public void LoadFromFile()
    {
        // TODO: Implement the logic to load the journal entries from a file
    }

    // This is a method that returns a random prompt for the user to write a response
    public string GetPrompt()
    {
        // TODO: Implement the logic to generate a random prompt
        List<Prompt> prompts = new List<Prompt>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        return "";
    }

}