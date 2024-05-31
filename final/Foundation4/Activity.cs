using System;

public abstract class Activity
{
    protected string _date;
    protected double _duration;
    public Activity(double duration)
    {
        _date = GetDate();
        _duration = duration;
    }
    public string GetDate()
    {
        DateTime newDate = DateTime.Now; 
        return newDate.ToString("MM/dd/yyyy");
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}