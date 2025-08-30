using Chpt9_Methods;

// Invoking PrintTotalAmount Method
decimal[] prices = { 19.95m, 25.50m, 8.99m, 12.75m, 5.49m };

PrintTotalAmountForBooks.PrintTotalAmount(prices);
PrintTotalAmountForBooks.PrintTotalAmount(89.95m, 265.50m, 85.1099m, 162.7m, 5.49m);

// Invoking PassingArgOfRefType Method
int[] arrArg = { 1, 2, 3 };

Console.Write("Before ModifyArray() the argument is: ");
PassingArgOfRefType.PrintArray(arrArg);

// Modifying the array's argument
PassingArgOfRefType.ModifyArray(arrArg);

Console.Write("After ModifyArray() the argument is: ");
PassingArgOfRefType.PrintArray(arrArg);


// Invoking ParamsDeclaration Method
long sum = ParamsDeclaration.CalcSum(2, 8);
Console.WriteLine(sum);

long sum2 = ParamsDeclaration.CalcSum(1, 2, 3, 4, 5);
Console.WriteLine(sum2);

long sum3 = ParamsDeclaration.CalcSum(10, 20, 30, 40, 50, 60, 70, 80, 90, 100);
Console.WriteLine(sum3);

long sum4 = ParamsDeclaration.CalcSum();
Console.WriteLine(sum4);

Sum(5, b: 10);

// Printing Triangle
//Entering the value of the variable n
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

// Printing the upper part of the triangle
for (int line = 1; line <= n; line++)
{
    PrintLine(1, line);
}

// Printing the bottom part of the triangle
// that is under the longest
for (int line = n - 1; line >= 1; line--)
{
    PrintLine(1, line);
}



// How to use optional parameters
// Method with optional parameters
static void Sum(int a, int b = 3, int c = 5)
{
    Console.WriteLine(a + b + c);
}

// Print Triangle
static void PrintLine(int start, int end)
{
    for (int i = start; i < end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

// Return Operator
static int CompareTo(int number1, int number2)
{
    if (number1 > number2)
    {
        return 1;
    }
    else if (number1 == number2)
    {
        return 0;
    }
    else
    {
        return -1;
    }
}

CompareTo(23, 27);

// TemperatureConverter Method

static double ConvertFahrenheitToCelsius(double temperatureF)
{
    double temperatureC = (temperatureF - 32) * 5 / 9;
    return temperatureC;
}
// Temperature Converter call

Console.Write("Enter your body temperature in Fahrenheit degrees: ");
double temperature = double.Parse(Console.ReadLine());

temperature = ConvertFahrenheitToCelsius(temperature);

Console.WriteLine("Your body temperature in Celsius degrees is {0}.", temperature);

if (temperature >= 37)
{
    Console.WriteLine("You are ill!");
}

// Months Invoke
Console.Write("Frist month (1 - 12): ");
int firstMonth = int.Parse(Console.ReadLine());

Console.Write("Second month (1-12): ");
int secondMonth = int.Parse(Console.ReadLine());

Months.SayPeriod(firstMonth, secondMonth);

// Data Validation Call
DataValidation.HourMinuteCall();

// invoke Sort Method
int[] numbers = SortingEngine.Sort(10, 3, 5, -1, 0, 12, 8);
SortingEngine.PrintNumbers(numbers);


static void Greet(string name)
{
    Console.WriteLine("Hello, {0}", name);
}
Greet("Emmanuel");