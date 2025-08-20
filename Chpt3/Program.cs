using System;

class Chpt3
{
    static void Main(string[] args)
    {
        // Task 1: Check if a number is even or odd
        Console.WriteLine("Enter a number to check if it is even or odd: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }

        //Task 2: Check if a number is divisible by both 5 and 7
        bool isDivisibleBy5and7 = number % 5 == 0 && number % 7 == 0;
        if (isDivisibleBy5and7)
        {
            Console.WriteLine($"{number} is divisible by both 5 and 7.");
        }
        else
        {
            Console.WriteLine($"{number} is not divisible by both 5 and 7.");
        }

        // Task 3: Check if the third digit from the right is 7
        Console.WriteLine("Enter a number to check if the third digit from the right is 7: ");
        int num = int.Parse(Console.ReadLine());
        bool isThirdDigit7 = (Math.Abs(num) / 100) % 10 == 7;

        Console.WriteLine("Third digit from the right is 7? " + isThirdDigit7);

        // Task 4: Check if the third bit (position 3) is 0 or 1
        // The third bit corresponds to the value 2^3 = 8
        Console.WriteLine("Enter an integer to check if the 3rd bit is 0 or 0ne: ");
        int inputNumber = int.Parse(Console.ReadLine());

        bool isThirdBitOne = (inputNumber & 8) != 0;

        Console.WriteLine($"The third bit (position 3) of {inputNumber} is {(isThirdBitOne ? "1" : "0")}");






    }
}
