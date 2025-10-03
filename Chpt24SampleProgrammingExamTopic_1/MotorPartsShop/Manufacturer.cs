using System;

namespace Chpt24SampleProgrammingExamTopic_1.MotorPartsShop;

public class Manufacturer
{
    private string name;
    private string country;
    private string phoneNumber;
    private string address;
    private string email;

    public Manufacturer(string name, string country, string phoneNumber, string address, string email)
    {
        this.name = name;
        this.country = country;
        this.phoneNumber = phoneNumber;
        this.address = address;
        this.email = email;
    }

    public override string ToString()
    {
        return $"<{name},{country},{phoneNumber},{address},{email}";
    }
}
