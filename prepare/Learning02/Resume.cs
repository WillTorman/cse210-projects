public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name} \n Jobs:");

        // Got this loop from the sample solution, because I could not figure it out. Originally I had "Jobs: {_jobs}"
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}