using System.ComponentModel.DataAnnotations;

public class Reference
{
    public Reference(string Book, string Chapter, string Verse)
    {
        string _book = Book;
        string _chapter = Chapter;
        string _verse = Verse;
    }

    private string Book;

    private string Chapter;

    private string Verse;

    public void Display()
    {
        Console.WriteLine($"{Book} {Chapter}:{Verse}");
    }
}