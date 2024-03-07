public class Scripture
{
    private string scripture;
    private List<string> words = new List<string>();
    private Random random;

    public Scripture(string scripture)
    {
        this.scripture = scripture;
        this.random = new Random();

        // Split verse into words using sentence separator
        string[] separators = new string[] {",", ".", " ", ";", "-", "!", "?", ":"};
        // Copilot helped me here
        string[] wordsArray = scripture.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        // Add words to the list
        foreach (string word in wordsArray)
        {
            words.Add(word);
        }
    }

    public void Display()
    {
        // Display each word
        foreach (string word in this.words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }


    // More help from Copilot
    public void HideRandomWords()
    {
        for (int i = 0; i < 3; i++)
        {
            if (this.words.Count > 0)
            {
                int index = this.random.Next(this.words.Count);
                this.words[index] = "____";
            }
        }
    }

    public bool AreAllWordsHidden()
    {
        return this.words.All(word => word == "____");
    }
}