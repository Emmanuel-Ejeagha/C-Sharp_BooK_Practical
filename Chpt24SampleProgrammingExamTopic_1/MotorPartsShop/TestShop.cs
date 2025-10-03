using System;

namespace Chpt24SampleProgrammingExamTopic_1.MotorPartsShop;

public class TestShop
{
    public static void RunTestShop()
    {

        Manufacturer bmw = new Manufacturer("BWM",
    "Germany", "Bavaria", "665544", "876666");
        Manufacturer lada = new Manufacturer("Lada",
        "Russia", "Moscow", "653443", "893321");

        Car bmw316i = new Car("BMW", "316i", 1994);
        Car ladaSamara = new Car("Lada", "Samara", 1987);
        Car mazdaMX5 = new Car("Mazda", "MX5", 1999);
        Car mercedesC500 = new Car("Mercedes", "C500", 2008);
        Car trabant = new Car("Trabant", "super", 1966);
        Car opelAstra = new Car("Opel", "Astra", 1997);

        Part cheapPart = new Part("Tires 165/50/R13", 302.36m,
        345.58m, lada, "T332", PartCategory.Tires);
        cheapPart.AddSupportedCar(ladaSamara);
        cheapPart.AddSupportedCar(trabant);
        Part expensivePart = new Part("Universal Car Engine",
        6733.17m, 6800.0m, bmw, "EU33", PartCategory.Engine);

        expensivePart.AddSupportedCar(bmw316i);
        expensivePart.AddSupportedCar(mazdaMX5);
        expensivePart.AddSupportedCar(mercedesC500);
        expensivePart.AddSupportedCar(opelAstra);

        Shop newShop = new Shop("Tuning Pro Shop");
        newShop.AddPart(cheapPart);
        newShop.AddPart(expensivePart);
        Console.WriteLine(newShop);
    }

}