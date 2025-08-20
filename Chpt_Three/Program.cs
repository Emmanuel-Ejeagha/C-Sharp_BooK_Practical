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

        // Task 5: An expression that calculates the area of a trapezoid
        Console.WriteLine("Enter the lengths of the two parallel sides of the trapezoid (a and b) and the height (h): ");
        double a = double.Parse(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());
        double area = ((a + b) / 2) * h;
        Console.WriteLine($"The area of the trapezoid with sides {a} and {b} and height {h} is: {area}");

        // Task 6: Program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user
        Console.WriteLine("Enter the length and width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double rectangleArea = width * height;

        Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");
        Console.WriteLine($"The area of the rectangle is: {rectangleArea}");

        Console.Write("Enter number: ");
        int inputNum = Convert.ToInt32(Console.ReadLine());
        int result = inputNum * 0.17;

        Console.WriteLine();



    }
}
