public class Checklist : Goal
{
    private int _necessaryActions;
    // Initialize current actions
    private int _currentActions = 0;
    private int _bonusPoints;

    public Checklist() : base()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _necessaryActions = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus for accomplishing it the goal that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());

        Console.WriteLine($"-- Currently completed: {_currentActions}/{_necessaryActions}");
    }

    // public override void Load()
    // {

    // }

    // public override void Save()
    // {

    // }

    // public override void Display()
    // {

    // }
    public string GetCurrentProgress()
    {
        return $"-- Currently completed: {_currentActions}/{_necessaryActions}";
    }

    public override void RecordEvent()
    {
        _currentActions++; //Increment the counter each time the function is called.

        // Check if all actions have been completed
        if (_currentActions >= _necessaryActions)
        {
            Console.WriteLine($"Goal accomplished {_currentActions} times, you earned {_bonusPoints} bonus points!");
        }
    }
}