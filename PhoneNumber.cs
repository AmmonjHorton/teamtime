using System;

public class PhoneNumber
{
    string _areaCode = "000";
    string _prefix = "000";
    string _suffix = "0000";

    public void DisplayNumber()
    {
        Console.WriteLine($"({_areaCode}) {_prefix}-{_suffix}");
    }
}

