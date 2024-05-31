using System;

public class Swimming : Activity
{
    private double _laps;
    private double _distance;


    public Swimming(double duration, double laps) :base(duration)
    {
        _laps = laps;
        _duration = duration;
        _distance = _laps * 50 / 1000 * 0.62;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _duration *60;
    }
    public override double GetPace()
    {
        return _duration / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_laps} laps)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace {GetPace():F1} min per mile";  
    }
}