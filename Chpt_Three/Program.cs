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
        Console.WriteLine("Enter a number to check if it is divisible by both 5 and 7: ");
        int numberDiv = Convert.ToInt32(Console.ReadLine());
        bool isDivisibleBy5and7 = numberDiv % 5 == 0 && numberDiv % 7 == 0;
        if (isDivisibleBy5and7)
        {
            Console.WriteLine($"{numberDiv} is divisible by both 5 and 7.");
        }
        else
        {
            Console.WriteLine($"{numberDiv} is not divisible by both 5 and 7.");
        }

        // Task 3: Check if the third digit from the right is 7
        Console.WriteLine("Task 3: Check if the third digit from the right is 7");
        Console.WriteLine("Enter a number to check if the third digit from the right is 7: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isThirdDigit7 = (Math.Abs(num) / 100) % 10 == 7;

        Console.WriteLine("Third digit from the right is 7? " + isThirdDigit7);

        // Task 4: Check if the third bit (position 3) is 0 or 1
        // The third bit corresponds to the value 2^3 = 8
        Console.WriteLine("Enter an integer to check if the 3rd bit is 0 or 0ne: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        bool isThirdBitOne = (inputNumber & 8) != 0;

        Console.WriteLine($"The third bit (position 3) of {inputNumber} is {(isThirdBitOne ? "1" : "0")}");

        // Task 5: An expression that calculates the area of a trapezoid
        Console.WriteLine("Enter the lengths of the two parallel sides of the trapezoid (a and b) and the height (h): ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine($"The area of the trapezoid with sides {a} and {b} and height {h} is: {area}");

        // Task 6: Program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user
        Console.WriteLine("Task 6: Calculate the perimeter and area of a rectangle");
        Console.WriteLine("Enter the length and width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        double height = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double rectangleArea = width * height;

        Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
        Console.WriteLine($"The area of the rectangle is: {rectangleArea}");

        //Task 7: a program that calculates the weight of a man on the moon by a given weight on the Earth.
        Console.WriteLine("Task 7: Calculate weight on the Moon");
        Console.Write("Enter your weight on Earth (in kg): ");
        double earthWeight = Convert.ToDouble(Console.ReadLine());

        double moonWeight = earthWeight * 0.17;

        Console.WriteLine($"Your weight on the Moon would be: {moonWeight} kg");

        // Task 8: Check if a point is inside a circle with radius 5 centered at the origin. Pythagorean theorem
        Console.WriteLine("Task 8: Check if a point is inside a circle with radius 5 centered at the origin");
        Console.WriteLine("Enter x coordinate: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter y coordinate: ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool isInsideCircle = (x * x + y * y) <= 25;

        Console.WriteLine($"Point ({x}, {y} is inside the circle? {isInsideCircle})");

        // Task 9: Check if a point is inside a circle with radius 5 centered at the origin and outside a rectangle with corners (-1, 1), (5, 1), (5, 5), (-1, 5)
        Console.WriteLine("Task 9: Check if a point is inside a circle and outside a rectangle");
        Console.Write("x = ");
        double xCoord = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double yCoord = Convert.ToDouble(Console.ReadLine());

        bool isInsideCircleAndOutsideRect = (xCoord * xCoord + yCoord * yCoord <= 25) && (xCoord < -1 || xCoord > 5 || yCoord < 1 || yCoord > 5);

        Console.WriteLine($"Is the point ({xCoord}, {yCoord}) inside the circle and outside the rectangle? {isInsideCircleAndOutsideRect}");

        /*
        Console.WriteLine("Enter the first number (Integer): ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number (Integer): ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number (Integer): ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the fourth number (Integer): ");
        int fourthNumber = Convert.ToInt32(Console.ReadLine());

        int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;
        int reversedOrder = fourthNumber * 1000 + thirdNumber * 100 + secondNumber * 10 + firstNumber;
        int lastDigitToFirst = 
        */

        // Task 10: Program that takes a four-digit number and performs various operations
        Console.WriteLine("Task 10: Operations on a four-digit number");
        Console.WriteLine("Enter a four-digit number: ");
        int fourDigitNumber = Convert.ToInt32(Console.ReadLine());

        int firstDigit = fourDigitNumber / 1000;
        int secondDigit = (fourDigitNumber / 100) % 10;
        int thirdDigit = (fourDigitNumber / 10) % 10;
        int fourthDigit = fourDigitNumber % 10;

        int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine($"Sum of digits: {sumOfDigits}");

        Console.WriteLine($"Reverved order: {fourthDigit}{thirdDigit}{secondDigit}{firstDigit}");

        Console.WriteLine($"Last digit to first: {fourthDigit}{firstDigit}{secondDigit}{thirdDigit}");

        Console.WriteLine($"Swap 2nd and 3rd digits: {firstDigit}{thirdDigit}{secondDigit}{fourthDigit}");

        // Task 11: Program that checks the value of a bit at a given position in a number
        Console.WriteLine("Task 11: Check the value of a bit at a given position");
        Console.WriteLine($"Enter number n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter bit position p: ");
        int p = Convert.ToInt32(Console.ReadLine());

        int bitValue = (n >> p) & 1;

        Console.WriteLine($"The value of the bit at position {p} in the number {n} is: {bitValue}");

        // Task 12: Program that checks if a bit at a given position in a number is set (1) or not (0)
        Console.WriteLine("Enter number v:");
        int v = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter bit position p: ");
        int p2 = Convert.ToInt32(Console.ReadLine());

        bool isBitSet = (v & (1 << p2)) != 0;

        Console.WriteLine($"Is the bit at position {p2} in the number {v} set? {(isBitSet ? "True" : "False")}");

    }
}
