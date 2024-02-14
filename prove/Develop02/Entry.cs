using System.Net;

public class Entry
{
    // These are fields that store the response, the prompt, and the date as strings
    public string response;
    public string prompt;
    public string date;

    // This is a constructor that creates an entry from a response and a prompt
    public Entry(string response, string prompt, string date)
    {
        // Assign the response and the prompt to the fields
        this.response = response;
        this.prompt = prompt;
        this.date = date;
    }

    // This is a constructor that creates an entry from a string
    public Entry(string import)
    {

    }

    // This is a method that displays the entry details on the console
    public void Display()
    {

    }

    // This is a method that exports the entry details as a string
    public string Export()
    {
        return "";
    }
}