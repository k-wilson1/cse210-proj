using System;

public class Reception : Event
{
    private string _register;

    public Reception(string type, string title, string description, string date, int time, string register, Address address) : base("Reception", title, description, date, time, address)
    {
        _type = "Reception";
    }

    public void SetRegister(string register)
    {
        _register = register;
    }
    public string GetRegister()
    {
        return _register;
    }
    public string GetFullReceptionDetail()
    {
        return $"Full Details:\nEvent: {_title}\nDetails: {_description}\nDate: {_date}\nLocation: \n{GetAddress()}\nPlease RSVP to: {_register}";
    }
    
}