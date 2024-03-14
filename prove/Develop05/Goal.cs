using System.IO;

public class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal()
    {
        _isCompleted = false;
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();

        Console.WriteLine("Give a short description of the goal: ");
        _description = Console.ReadLine();

        Console.WriteLine("How many points are associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual void Display(int index)
    {
        // ? uses boolean logic to determine whether box is crossed or not
        char checkbox = _isCompleted ? 'X' : ' '; 
        Console.WriteLine($"{index}. [{checkbox}] {_goalName}: {_description}");
    }

    public virtual void RecordEvent()
    {

    }

    // public virtual void Load()
    // {
    //     // Code from Assignment
    //     string filename = "myFile.txt";
    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split(",");

    //         string firstName = parts[0];
    //         string lastName = parts[1];
    //     }
    // }

    // public virtual void Save()
    // {
    //     // Code from Assignment
    //     string fileName = "myFile.txt";

    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         // You can add text to the file with the WriteLine method
    //         outputFile.WriteLine("This will be the first line in the file.");

    //         // You can use the $ and include variables just like with Console.WriteLine
    //         string color = "Blue";
    //         outputFile.WriteLine($"My favorite color is {color}");
    //     }
    // }
}