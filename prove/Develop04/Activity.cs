class Activity
{
    protected string startMsg = "Welcome to the ";
    protected string endMsg = $"Well done!\n\nYou have completed another ";

    // Constructor for the start & end messages
    public Activity(string startMsg, string endMsg)
    {
        this.startMsg = startMsg;
        this.endMsg = endMsg;
    }

    public string GetStartMsg()
    {
        return startMsg;
    }

    public string GetEndMsg()
    {
        return endMsg;
    }

    // animation function
    // get time function
}