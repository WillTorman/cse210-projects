using System;
using System.ComponentModel.Design;

class Program
{
    public Journal journal;
    static void Main(string[] args)
    {
        journal = new Journal();
        Console.WriteLine("Hello Develop02 World!");
        Run();
    }

    public string GetPrompt()
    {
        return "";
    }

    public void Run()
    {
        journal = new Journal();

        bool keepGoing = true;
        while (keepGoing)
        {
            var selection = ShowsMenu();

            // if 1
            if (Selection == 1)
            {
                // propmpt user with a random prompt
                // read in user input

                var entry = new Entry(response, prompt);
                journal.AddEntry(entry);
            }
            else if (selection == 2)
            {
                // display entries

            }
            else if (selection == 3)
            {
                keepGoing = false;
            }
        }
    }

    static void ShowsMenu()
    {
        Console.WriteLine("Select Option: \n 1. Add Entry \n 2. Display Entry \n 3.");
        string input = Console.ReadLine();
        return int.Parse(input);
    }
    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }
}