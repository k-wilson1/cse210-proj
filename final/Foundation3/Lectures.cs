using System;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string type, string title, string description, string date, int time, string speaker, int capacity, Address address) : base("Lecture", title, description, date, time,address)
    {
        _speaker = speaker;
        _capacity = capacity;
    

    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public string GetSpeaker()
    {
        return _speaker;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public string GetFullLectureDetails()
    {
        return $"Full Details:\nEvent: {_title}\nDetails: {_description}\nDate: {_date}\nLocation: \n{GetAddress()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}