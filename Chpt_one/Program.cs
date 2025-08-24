using System;



class HelloSharp
{
    static void Main(string[] args)
    {
        //Task 1: Print a welcome message
        Console.WriteLine("Welcome to C# programming!");
        Console.WriteLine("Hello World!");
        Console.WriteLine("My name is Emmanuel Ejeagha");

        //Task 2: Print a simple arithmetic operation
        int num1 = 101;
        int num2 = 1001;

        Console.WriteLine(num1);
        Console.WriteLine(num2);



        // Task 3: Print the current date and time     
        Console.WriteLine("Current date and time: " + DateTime.Now);

        // Task 4: PRint the square root of 12345
        double number = 12345;
        double result = Math.Sqrt(number);
        Console.WriteLine($"The square root of {number} is: {result}");

        // Task 5: Print even numbers from 2 to 100, and odd numbers as negative
        int count = 100;

        for (int i = 2; i <= count; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i}, ");
            }
            else
            {
                Console.Write($"-{i}, ");
            }
        }
        Console.WriteLine();

        Console.Write("Enter your age and I will subtract 10 from your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your age minus 10 is : {age - 10}");



    }

}