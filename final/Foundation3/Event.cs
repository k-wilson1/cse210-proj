using System;

public class Event
{
    protected string _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected int _time;
    protected Address _address;

    public Event(string type, string title, string description, string date, int time, Address address)
    {
        _type = type;
        _time = time;
        _address = address;
        _description = description;
        _date = date;
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public int GetTime()
    {
        return _time;
    }
    public void SetTime(int time)
    {
        _time = time;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
    public string GetStandardDetails()
    {
        return $"Standard Details:\nEvent: {_title}\nDetails: {_description}\nDate: {_date}\nLocation:\n{GetAddress()}";
    }
    public string GetShortDescription()
    {
        return $"Short Details:\nEvent type:{_type}\nEvent: {_title}\nDate: {_date}";
    }
}