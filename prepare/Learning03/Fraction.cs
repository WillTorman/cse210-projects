using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public GetTop()
    {

    }

    public SetTop(top)
    {

    }

    public GetBottom()
    {

    }

    public void SetBottom(bottom)
    {
        _bottom = ;
    }

    public string GetFractionString()
    {
        Console.WriteLine($"{top}/{bottom}");
    }

    public double GetDecimalValue()
    {

    }
}