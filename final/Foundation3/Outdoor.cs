using System;

public class Outdoor : Event
{
    private string _weather;
    
    public Outdoor(string type, string title, string description, string date, int time, string weather, Address address) : base(type, title, description, date, time, address)
    {
        _weather = weather;
        _type = "Outdoor";
    }
    public void SetWeather(string weather)
    {
        _weather = weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public string GetFullOutdoorDetails()
    {
        return $"Full Details:\nEvent: {_title}\nDetails: {_description}\nDate: {_date}\nLocation:\n{GetAddress()}\nType: {_type}\nThe weather will be {_weather}, please plan accordingly";
    }
    
}