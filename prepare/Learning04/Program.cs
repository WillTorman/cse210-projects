using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");
        Assignment ass1 = new Assignment("William Torman", "Multiplication");
        Console.WriteLine(ass1.GetSummary() + "\n");

        MathAssignment math1 = new MathAssignment("Satoru Gojo", "Addition", "3.2", "1-15");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList() + "\n");

        WritingAssignment write1 = new WritingAssignment("Suguru Geto", "U.S. History", "Why the U.S. is Awesome");
        Console.WriteLine(write1.GetStudentName());
        Console.WriteLine(write1.GetWritingInformation());
    }
}