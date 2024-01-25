using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Nvidia";
        job1._jobTitle = "AI Lead";
        job1._startYear = 2020;
        job1._endYear = 2024;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "AMD";
        job2._jobTitle = "Chip Designer";
        job2._startYear = 2017;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "William";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Display the info
        resume1.DisplayResume();
    }
}
