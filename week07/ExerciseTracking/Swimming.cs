using System;

public class Swimming : Activity
{
    private int _laps; // number of laps
    private const double LapDistance = 0.05; // each lap is 0.05 miles (assuming a 25-yard pool)

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * LapDistance; // distance = laps * lap distance
    }
    public override double GetSpeed()
    {
        return (GetDistance() / base._duration) * 60; // miles per hour
    }
    public override double GetPace()
    {
        return (double)base._duration / GetDistance(); // minutes per mile
    }
    public override string GetSummary()
    {
        return $"{_date:yyyy-MM-dd} Swimming ({_duration} min) - Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min/mile";
    }
}