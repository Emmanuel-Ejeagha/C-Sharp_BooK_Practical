using System;

namespace Chpt14Classes;

//  Class declaration
public class Dog
{
    // Feild declaration
    private string name;

    // Constructor declaration (parameterless empty constructor)
    public Dog()
    {

    }

    // Another constructor declaration
    public Dog(string name)
    {
        this.name = name;
    }

    // Property declaration
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //  Method declaration (non-static)
    public void Bark()
    {
        Console.WriteLine("{0} said: Wow-wow!", name ?? "[unnamed dog]");
    }
}
