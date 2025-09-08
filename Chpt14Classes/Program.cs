using Chpt14Classes;

string? firstDogName = null;
Console.Write("Enter first dog name: ");
firstDogName = Console.ReadLine();

// Using a constructor to create a dog with specified name
Dog firstDog = new Dog(firstDogName);

// Using a constructor to create a dog with a defualt name
Dog secondDog = new Dog();

Console.Write("Enter the second dog name: ");
string? secondDogName = Console.ReadLine();

// Using property to set the name of the dog
secondDog.Name = secondDogName;

// Creating a dog with a default name
Dog thirdDog = new Dog();

Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

foreach (Dog dog in dogs)
{
    dog.Bark();
}


// Call the Coffee Method
Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
Coffee doubleCoffee = new Coffee(CoffeeSize.Double);
Coffee smallSize = new Coffee(CoffeeSize.Small);

Console.WriteLine("The {0} coffee is {1} ml.", normalCoffee.Size, (int)normalCoffee.Size);
Console.WriteLine("The {0} coffee is {1} ml.", doubleCoffee.Size, (int)doubleCoffee.Size);
Console.WriteLine("The {0} coffee is {1} ml.", smallSize.Size, (int)smallSize.Size);


// Call Outer class
/*
OuterClass outerClass = new OuterClass("outer");
NestedClass nestedClass = new
OuterClass.NestedClass(outerClass, "nested");
nestedClass.PrintNames();
*/

// Animal Shelter
AnimalsShelter dogsShelter = new AnimalsShelter(10);
Dog dog1 = new Dog();
Dog dog2 = new Dog();
Dog dog3 = new Dog();

dogsShelter.Shelter(dog1);
dogsShelter.Shelter(dog2);
dogsShelter.Shelter(dog3);

dogsShelter.Release(1);

Swapping s = new Swapping();
s.PrintSwap();

