// This is a class that represents a journal with a list of entries
public class Journal
{
    // This is a field that stores the entries as a list
    public List<Entry> entries;

    // This is a constructor that creates an empty journal
    public Journal()
    {
        // Initialize the entries list
        entries = new List<Entry>();
    }

    // This is a constructor that creates a journal from a string
    public Journal(string import)
    {
        // TODO: Implement the logic to parse the string and create the entries list
    }

    // This is a method that adds a new entry to the journal
    public void AddEntry(Entry entry)
    {
        // Add the entry to the list
        entries.Add(entry);
    }

    // This is a method that displays the journal entries on the console
    public void Display()
    {
        // Loop through the entries list
        foreach (Entry entry in entries)
        {
            // Print the entry details
            Console.WriteLine(entry.ToString());
        }
    }

    // This is a method that exports the journal entries as a string
    public string Export()
    {
        // Create a string builder to store the output
        StringBuilder sb = new StringBuilder();

        // Loop through the entries list
        foreach (Entry entry in entries)
        {
            // Append the entry details to the string builder
            sb.AppendLine(entry.ToString());
        }

        // Return the string representation of the journal
        return sb.ToString();
    }
}
