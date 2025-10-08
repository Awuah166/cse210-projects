using System;

public class CircleShape : Shape
{
    private double _radius;

    public CircleShape(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}