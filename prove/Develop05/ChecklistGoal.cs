using System;
using System.Runtime;
public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    { 
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points += _bonus;
            Console.WriteLine($"*******Congratulations you earned a bonus of {_bonus} points!*******");
        }
        else 
        {
            _points++;
        }
        
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {    
            return true;
        }
        else
        { 
            return false;
        }
    }
    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) -- {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{IsComplete()}|{_bonus}|{_target}|{_amountCompleted}";
    }

}