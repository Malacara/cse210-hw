using System;

public class Customer
{
    private string _name;
    private Address _address;
    private bool usaLocated;

    public Customer(string userName)
    {
        _name = userName;
    }

    public void CustomerAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }

    public string GetCustomer()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.DisplayAddress();
    }

    public bool Locate()
    {
        usaLocated = _address.ItsFromUsa();
        return usaLocated;
    }

}