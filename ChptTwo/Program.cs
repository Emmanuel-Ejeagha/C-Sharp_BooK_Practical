// Data types in C#

// Task 1: 
sbyte signedByte = -44;
byte unsignedByte = 97;
short signedShort = -115;
ushort unsignedShort = 112;
int signedInt = -10000;
int signedInt2 = 52130;
uint unsignedInt = 1990;
uint unsignedInt2 = 20000;
long signedLong = -1000000;
long signedLong2 = 4825932;
ulong unsignedLong = 123456789123456789;
ulong unsignedLong2 = 970000000;

Console.WriteLine("Signed Byte: " + signedByte);
Console.WriteLine($"Unsigned Byte: {unsignedByte}");
Console.WriteLine($"Signed Short: {signedShort}");
Console.WriteLine($"Unsigned short: {unsignedShort}");
Console.WriteLine($"Signed Int: {signedInt}");
Console.WriteLine($"Signed Int2: {signedInt2}");
Console.WriteLine($"Unsigned Int: {unsignedInt}");
Console.WriteLine($"Unsigned Int2: {unsignedInt2}");
Console.WriteLine($"Signed Long: {signedLong}");
Console.WriteLine($"Signed Long2: {signedLong2}");
Console.WriteLine($"Unsigned Long: {unsignedLong}");
Console.WriteLine($"Unsigned Long2: {unsignedLong2}");


// Task 2:
// Floating point types
// float, double, decimal
float num1 = -5565.01234567f;
double num2 = 34.567839023d;
double num3 = 8923.1234857d;
decimal num4 = 3456.091124875956542151256683467m;

Console.WriteLine("Float num1: " + num1);
Console.WriteLine("Double num2: " + num2);
Console.WriteLine("Double num3: " + num3);
Console.WriteLine("Decimalnum4: " + num4);


// Task 3: Compares two real numbers with precision of 0.000001
const double Epsilon = 0.000001;

Console.WriteLine("Enter the first real number: ");
double number1 = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the second real number: ");
double number2 = double.Parse(Console.ReadLine());

bool areEqual = Math.Abs(number1 - number2) < Epsilon;

if (areEqual)
{
    Console.WriteLine($"The numbers are equal (with precision {Epsilon}.)");
}
else
{
    Console.WriteLine($"The numbers are different (with precision {Epsilon}.)");
}

// Task 4:
// Hexadecimal representation of an integer
// 0x100 is the hexadecimal representation of 256 in decimal
int num = 0x100;

Console.WriteLine($"Hexadecimal 0x100 in decimal is: {num}");

// Task 5:
// Characters and Unicode
char myChar = (char)72; // ASCII value for 'H'
Console.WriteLine($"Character for ASCII value 72 is: {myChar}");
char character = '\u0048'; // Unicode for 'H'
Console.WriteLine($"Unicode character for '\\u0048' is: {character}");

// Task 6:
// Boolean type
bool isMale = true;

if (isMale)
{
    Console.WriteLine("The person is a Male.");
}
else
{
    Console.WriteLine("The person is a female.");
}

// Task 7:
// String concatenation
string greeting1 = "Hello";
string greeting2 = "World";
object combinedGreeting = greeting1 + " " + greeting2;
Console.WriteLine($"Combined greeting: {combinedGreeting}");

// Task 8:
// String interpolation
string quote1 = "The \"use\" of quotations causes difficulties.";
string quote2 = @"The ""use"" of quotations causes difficulties.";

Console.WriteLine($"Quote with escape characters: {quote1}");
Console.WriteLine($"Quote with verbatim string: {quote2}");

Console.WriteLine("   o   o   ");
Console.WriteLine("  ooo ooo  ");
Console.WriteLine("ooooooooooo");
Console.WriteLine("  ooooooo  ");
Console.WriteLine("   ooooo   ");
Console.WriteLine("    ooo    ");
Console.WriteLine("     o     ");









