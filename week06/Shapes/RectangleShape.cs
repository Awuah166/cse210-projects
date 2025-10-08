using System;

public class RectangleShape : Shape
{
    private double _width;
    private double _length;

    public RectangleShape(string color, double width, double length) : base(color)
    {
        _width = width;
        _length = length;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}