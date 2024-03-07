using System.Globalization;

class Square : Shape
{
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return base.GetArea() + _side * _side;
    }
}