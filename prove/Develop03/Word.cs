public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text, bool isHidden)
    {
        this.text = text;
        this.isHidden = isHidden;
    }

    public void Display()
    {
        if (this.isHidden)
        {
            Console.Write("____ ");
        }
        else
        {
            Console.Write(this.text + " ");
        }
    }

    public bool GetHidden()
    {
        return isHidden;
    }

    public void SetHidden(bool isHidden)
    {
        this.isHidden = isHidden;
    }
}