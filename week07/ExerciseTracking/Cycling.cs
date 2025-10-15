using System;

public class Cycling : Activity
{
    private double _speed; // in miles
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed / 60) * _duration; // distance = speed * time
    }
    public override double GetSpeed()
    {
        return _speed; // miles per hour
    }
    public override double GetPace()
    {
        return 60 / _speed; // minutes per mile
    }
    public override string GetSummary()
    {
        return $"{_date:yyyy-MM-dd} Cycling ({_duration} min) - Distance: {GetDistance():0.00} miles, Speed: {_speed:0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}