using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public int GetBonus()
    {
        return 0; // Default implementation, override in derived classes if needed
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName}, {_description}, {_points}";
    }

    public virtual string GetGoalType()
    {
        return "Goal";
    }
    
    public abstract string GetStringRepresentation();
}