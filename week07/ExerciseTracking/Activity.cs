using System;

public abstract class Activity
{
    protected string _date; // date in format "YYYY-MM-DD"
    protected int _duration; // duration in minutes

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed(); // in miles per hour
    public abstract double GetPace(); // in minutes per mile
    public abstract string GetSummary();
}