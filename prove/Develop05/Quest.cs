public class Quest
{
    public List<string> goals = new List<string>();
    public int _pointsTotal;

    public void displayGoals()
    {
        // For loop to display all entries in list
        foreach (string goal in goals)
        {
            Console.WriteLine(goal);
        }
    }
}