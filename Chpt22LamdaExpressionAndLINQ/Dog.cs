using System;

namespace Chpt22LamdaExpressionAndLINQ;

/// <summary>Lamda Expression playground</summary>
public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }

    public static List<Dog> dogs = new List<Dog>()
        {
            new Dog { Name = "Rex", Age = 4 },
            new Dog { Name = "Sean", Age = 0},
            new Dog { Name = "Stacy", Age = 3}
        };

    public static void GetDogDetails()
    {

        var names = dogs.Select(x => x.Name);
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
        foreach (var newDogs in newDogsList)
        {
            Console.WriteLine(newDogs);
        }

    }

    public static void SortedDogs()
    {
        var sortedDogs = dogs.OrderByDescending(x => x.Age);

        foreach (var dog in sortedDogs)
        {
            Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
        }
    }
}
