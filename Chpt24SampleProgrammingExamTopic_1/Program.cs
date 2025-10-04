using Chpt24SampleProgrammingExamTopic_1;
using Chpt24SampleProgrammingExamTopic_1.MotorPartsShop;

HTMLTagRemover.RunHTMLTagRemover();
SimpleHtmlTagRemover.RunSimpleHtmlTagRemover();

Maze maze = new Maze();
maze.ReadFromFile(Maze.InputFileName);
int pathLength = maze.FindShortestPath();
maze.SaveResult(Maze.OutputFileName, pathLength);


// Test for manufacturer, Car, Part
Manufacturer manufacturer = new Manufacturer("Toyota", "America", "+1 248-7390-2", "New York", "toyota@toyota.motor");
Console.WriteLine(manufacturer);

Manufacturer bmw = new Manufacturer("BMW", "Germany", "Bavaria", "665544", "bmw@yahoo.com");

Part partEngineOil = new Part("BMW Engine Oil", 633.17m, 679.0m, bmw, "Oil431", PartCategory.Engine);

Car bmw316i = new Car("BMW", "318i", 1994);
partEngineOil.AddSupportedCar(bmw316i);

Car mazdaMX5 = new Car("Mazda", "MX5", 1999);
partEngineOil.AddSupportedCar(mazdaMX5);

Console.WriteLine(partEngineOil);

// Test for Duplicates
partEngineOil.AddSupportedCar(new Car("BMW", "316i", 1994));
partEngineOil.AddSupportedCar(new Car("BMW", "X5", 2006));
partEngineOil.AddSupportedCar(new Car("BMW", "X5", 2007));
partEngineOil.AddSupportedCar(new Car("BMW", "X5", 2006));
partEngineOil.AddSupportedCar(new Car("BMW", "316i", 1994));
Console.WriteLine(partEngineOil);

// Test shop
TestShop.RunTestShop();
