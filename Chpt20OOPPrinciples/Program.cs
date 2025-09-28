using Chpt20OOPPrinciples;

Console.WriteLine(new object());
// Console.WriteLine(new Felidae(true));
Console.WriteLine(new Lion(true, 80));

OverrideExample.HowToOverride();

// Call the cat class. AbstractClas Example
AbstractClassExample.PrintAbstractClassExample();

// Virtual Methods Example
Lion lion = new Lion(true, 80);
lion.CatchPrey(null);

AfricanLion lion1 = new AfricanLion(true, 120);
lion1.CatchPrey(null);

Lion lion2 = new AfricanLion(false, 50);
lion2.CatchPrey(null);
