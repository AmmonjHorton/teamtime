using System;

public class Program
{
    public static void Main()
    {
        Address myaddress = new Address();

        myaddress._city = "Belton";
        myaddress._state = "SC";
        myaddress._zipCode = "29627";
        myaddress._street = "123 Main St";
        myaddress.DisplayMialingLabel();

        Address youraddress = new Address();

        youraddress.DisplayMialingLabel();



        PhoneNumber mynumber = new PhoneNumber();
        mynumber.DisplayNumber();
    }

}
