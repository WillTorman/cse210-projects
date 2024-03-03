using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", "13", "12");
        Scripture scripture = new Scripture("\nNow they, after being sanctified by the Holy Ghost, having their garments made white, being pure and spotless before God, could not look upon sin save it were with abhorrence; and there were many, exceedingly great many, who were made pure and entered into the rest of the Lord their God.");
        // Word word = new Word(scripture, false);

        Console.Clear();
        reference.Display();
        scripture.Display();

        while (true)
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }
            Console.Clear();
            scripture.HideRandomWords();
            reference.Display();
            scripture.Display();

            // Break if all are hidden
            if (scripture.AreAllWordsHidden())
            {
                break;
            }
        }
    }
}