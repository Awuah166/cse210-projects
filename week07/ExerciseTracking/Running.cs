using System;

public class Running : Activity
{
    private double _distance; // in miles

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / base._duration) * 60; // miles per hour
    }

    public override double GetPace()
    {
        return (double)base._duration / _distance; // minutes per mile
    }

    public override string GetSummary()
    {
        return $"{_date:yyyy-MM-dd} Running ({_duration} min) - Distance: {_distance} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}