using System;

namespace Chpt11_CreatingAndUsingObjects;

public class Cat
{
    // Field name
    private string name;
    // Field color
    private string color;

    public string Name
    {
        // Getter of the property
        get
        {
            return this.name;
        }
        // Setter of the property "Name"
        set
        {
            this.name = value;
        }
    }
    public string Color
    {
        // Getter of the property "Color
        get
        {
            return this.color;
        }
        // Setter of the property "Color"
        set
        {
            this.color = value;
        }
    }

    // Default constructor
    public Cat()
    {
        this.name = "Unnamed";
        this.color = "gray";
    }

    // ConStructor with parameters
    public Cat(string name, string color)
    {
        this.name = name;
        this.color = color;
    }

    // Methosd SayMiau
    public void SayMiau()
    {
        Console.WriteLine("Cat {0} said: Miauuuuu!", name);
    }

    public static void Run()
    {
        Cat firstCat = new Cat();
        firstCat.name = "Tony";
        firstCat.SayMiau();

        Cat secondCat = new Cat("Pepy", "red");
        secondCat.SayMiau();
        Console.WriteLine("Cat {0} is {1}.", secondCat.Name, secondCat.Color);
    }

}
