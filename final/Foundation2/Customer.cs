using System;
using System.Dynamic;

public class Customer
{
    private string _firstName;
    private string _lastName;
    private Address _address;
    public Customer()
    {
        _address = new Address();
    }
    public string GetCustomer()
    {
        return $"{_firstName} {_lastName}\n{_address.GetAddress()}";
    }
    public void SetCustomer(string firstName, string lastName, Address address)
    {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
    }
    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }

}