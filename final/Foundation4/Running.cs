using System;
using System.Runtime.CompilerServices;
public class Running : Activity
{
    private double _distance;
    public Running(double duration, double distance):base(duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _duration * 60;
    }
    public override double GetPace()
    {
        return _duration/_distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_duration} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1}mph, Pace {GetPace():F1} min per mile";
    }
}
