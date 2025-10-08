using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // Creating a List of Shape objects
        List<Shape> shapes = new List<Shape>();
        // Adding different shapes to the list
        shapes.Add(new SquareShape("Red", 4.0));
        shapes.Add(new RectangleShape("Blue", 3.0, 5.0));
        shapes.Add(new CircleShape("Green", 2.5));

        // Iterating through the list and displaying color and area of each shape
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}