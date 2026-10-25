using System;

public class Contact
{
    public string Name { get; }
    public string PhoneNumber { get; }
    public string Address { get; }

    public Contact(string name, string phoneNumber, string address)
    {
        this.Name = name;
        this.PhoneNumber = phoneNumber;
        this.Address = address;
    }
}
