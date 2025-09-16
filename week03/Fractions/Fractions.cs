using System;

public class Fractions
{
    private int _top;
    private int _bottom;

    // Constructor
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Creating a Get and Set method for the top and bottom
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Creating a method to display the fraction
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Creating a method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / (double) _bottom;
    }
}