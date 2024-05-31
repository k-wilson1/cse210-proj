using System;

public class Cycling : Activity
{
    private double _speed;
    private double _distance;

    public Cycling(double duration, double distance, double speed):base(duration)
    {
        _speed = speed;
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return 60 / GetPace();
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_speed:F1})-Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}