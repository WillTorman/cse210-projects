class Breathe : Activity
{
    private string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string promptBreathe = "Breathe in...";
    private string promptExhale = "Breathe out...";

    public Breathe(string startMsg, string endMsg, string description, string promptBreathe, string promptExhale) : base(startMsg, endMsg)
    {
        this.description = description;
        this.promptBreathe = promptBreathe;
        this.promptExhale = promptExhale;
    }

    // use an animation showing how long to breath in and out
    // counts 1.. 2.. 3.. 4.. 5.. or count down
}