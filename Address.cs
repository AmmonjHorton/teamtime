using System;

public class Address
{
    public string _street = "123 Anystreet";
    public string _city = "Anytown";
    public string _state = "Idaho";
    public string _zipCode = "88888";

    public PhoneNumber _phoneNumber = new PhoneNumber();

    public void DisplayMialingLabel()
    {
        Console.WriteLine($"{_street}\n{_city}, {_state} {_zipCode}");
    }
}

   
    // * street  
    // * city
    // * state
    // * zip code