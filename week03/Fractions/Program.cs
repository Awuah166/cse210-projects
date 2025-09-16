using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions f1 = new Fractions();      // 1/1
        Fractions f2 = new Fractions(6);    // 6/1
        Fractions f3 = new Fractions(6, 7); // 3/4

        // Using setters to change the values and getters to display them
        f1.SetTop(1);
        f1.SetBottom(1);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        f2.SetTop(5);
        f2.SetBottom(1);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());


    }
}