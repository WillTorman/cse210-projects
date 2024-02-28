class Listing : Activity
{
    private string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private List<string> prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };


    public Listing(string startMsg, string endMsg, string description) : base(startMsg, endMsg)
    {
        this.description = description;
    }

    private void randPrompt(List<string> prompts)
    {

    }
}