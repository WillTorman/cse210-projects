using System.IO;

public class Goal
{
    protected string _goalName;
    protected string _Description;
    protected int _pointsAwarded;


    public Goal()
    {

    }

    public virtual void Load()
    {
        // Code from Assignment
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }

    public virtual void Save()
    {
        // Code from Assignment
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    public virtual void Display()
    {

    }

    public virtual void RecordEvent()
    {

    }
}