// Program that reads from the console three numbers of type int and prints their sum.
Console.WriteLine("Task 1: Sum of three integers");
Console.WriteLine("Enter the first number (Integer): ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number (Integer): ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number (Integer): ");
int num3 = Convert.ToInt32(Console.ReadLine());

int sumOfThree = num1 + num2 + num3;
Console.WriteLine($"The sum of {num1}, {num2}, and {num3} is: {sumOfThree}");


// Task 2: Program that reads from the console the radius "r" of a circle and prints its perimeter and area.
Console.WriteLine("Task 2: Calculate the perimeter and area of a circle");
Console.WriteLine("Enter the radius of the circle: ");
double radius = Convert.ToDouble(Console.ReadLine());
double perimeterOfCircle = 2 * Math.PI * radius;
double areaOfCircle = Math.PI * radius * radius;
Console.WriteLine($"The perimeter of the circle with radius {radius} is: {perimeterOfCircle}");
Console.WriteLine($"The area of the circle with radius {radius} is: {areaOfCircle}");


// Task 3: Program that reads information about a company and its manager and prints it on the console.
Console.Write("Company name: ");
string companyName = Console.ReadLine();
Console.Write("Address: ");
string address = Console.ReadLine();
Console.Write("Phone number: ");
string phone = Console.ReadLine();
Console.Write("Fax number: ");
string fax = Console.ReadLine();
Console.Write("Website: ");
string website = Console.ReadLine();

Console.Write("Manager first name: ");
string mFirst = Console.ReadLine();
Console.Write("Manager surname: ");
string mLast = Console.ReadLine();
Console.Write("Manager phone: ");
string mPhone = Console.ReadLine();

Console.WriteLine("\n--- Company Info ---");
Console.WriteLine($"Name: {companyName}");
Console.WriteLine($"Address: {address}");
Console.WriteLine($"Phone: {phone}");
Console.WriteLine($"Fax: {fax}");
Console.WriteLine($"Website: {website}");
Console.WriteLine($"Manager: {mFirst} {mLast}, Phone: {mPhone}");

// Task 4: Program that prints numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned.
int numb1 = 234;
double numb2 = 23.4987;
double numb3 = -3456.091;

Console.WriteLine("{0,-10:X} {1,10:F2} {2,10:F3}", numb1, numb2, numb3);

Console.WriteLine("ENter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = a; i <= b; i++)
{
    if (i % 5 == 0)
    {
        count++;
    }
    Console.WriteLine($"Count of numbers divisible by 5 between {a} and {b} is: {count}");
}
