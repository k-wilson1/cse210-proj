using System;

public class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }
    public override void RecordEvent()
    {
        _points++;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} {_description}";
    }
    public override string GetStringRepresentation()
    {
        return $" {_shortName}|{_description}|{_points}|{IsComplete()}";
    }
}