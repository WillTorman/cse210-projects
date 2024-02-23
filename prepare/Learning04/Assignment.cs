class Assignment
{
    private string studentName;
    private string topic;

    public Assignment(string studentName, string topic)
    {
        this.topic = topic;
        this.studentName = studentName;
    }

    public string GetStudentName()
    {
        return studentName;
    }
    public string GetSummary()
    {
        return $"{studentName}: {topic}";
    }
}