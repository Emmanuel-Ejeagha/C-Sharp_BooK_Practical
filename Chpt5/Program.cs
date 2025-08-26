// Task 1: Sum of numbers from 1 to n
using System.Numerics;

// Task 1: Sum of numbers from 1 to n
Console.WriteLine("Task 1: Calculate the sum of numbers from 1 to n");
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;
int num = 0;

while (num < n)
{
    num++;
    sum += num;
    Console.Write(" + " + num);
}
Console.WriteLine(" = " + sum);


// Task 2: Check if a number is prime
Console.WriteLine("Task 2: Check if a number is prime");
Console.Write("Enter a positve integer: ");
int number = Convert.ToInt32(Console.ReadLine());
int divider = 2;
int maxDivider = (int)Math.Sqrt(number);
bool isPrime = true;

while (isPrime && (divider <= maxDivider))
{
    if (number % divider == 0)
    {
        isPrime = false;
    }
    divider++;
}
Console.WriteLine("Prime? " + isPrime);

// Task 3: Calculate the factorial of a number
Console.Write("Enter a number and I will calculate the factorial: ");
int numb = Convert.ToInt32(Console.ReadLine());
decimal factorial = 1;

while (true)
{
    if (numb <= 1)
    {
        break;
    }
    factorial *= numb;
    numb--;
}
Console.WriteLine($"The n! of {numb} is: {factorial}\n");

// Task 4: Factorial of a number using do-while loop
Console.Write("Enter a big number and I will calculate the factorial: ");
int numbr = Convert.ToInt32(Console.ReadLine());
BigInteger fact = 1; // Using BigInteger to handle large factorials like 100! 1000! etc

do
{
    fact *= numbr;
    numbr--;
} while (numbr > 0);
Console.WriteLine($"The n! of {numbr} is: {fact}\n");

// Task 5: Calculate the product of numbers in a range [x, y]
Console.WriteLine("Task 5: Calculate the product of numbers in a range [x, y]");
Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());

int number1 = x;
long product = 1;
do
{
    product *= number1;
    number1++;
} while (number1 <= y);
Console.WriteLine($"\nThe product of numbers from {y} to {x} is: {product}\n");

// Task 6: Print numbers from 0 to 10 using for loop
Console.WriteLine("Task 6: Print numbers from 0 to 10 using for loop");
for (int i = 0; i <= 10; i++)
{
    Console.Write(i + " ");
}

// Task 7: Print powers of 2 from 1 to 128 using for loop
Console.WriteLine("\n\nTask 7: Print powers of 2 from 1 to 128 using for loop");
for (int i = 1, sumLoop = 1; i <= 128; i *= 2, sum += 1)
{
    Console.WriteLine("i={0}, sum={1}", i, sumLoop);
}

// Task 8: Calculate n to the power of m
Console.WriteLine("\nTask 8: Calculate n to the power of m");
Console.Write("\nn = ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("m = ");
int m1 = Convert.ToInt32(Console.ReadLine());
decimal result = 1;

for (int i = 0; i < m1; i++)
{
    result *= n1;
}
Console.WriteLine($"{n1} to the power of {m1} is: {result}\n");

// Task 9: Print pairs of numbers using a single for loop
Console.WriteLine("\nTask 9: Print pairs of numbers using a single for loop");
for (int small = 1, large = 10; small < large; small++, large--)
{
    Console.WriteLine($"small = {small}, large = {large}");
}

// Task 9: Calculate the sum of odd numbers from 1 to a given number, skipping those divisible by 7
Console.WriteLine("\nTask 9: Calculate the sum of odd numbers from 1 to a given number, skipping those divisible by 7");
Console.Write("Enter a number: ");
int ab = int.Parse(Console.ReadLine());
int sum1 = 0;
for (int i = 1; i <= ab; i += 2)
{
    if (i % 7 == 0)
    {
        continue;
    }
    sum1 += i;
}
Console.WriteLine("The sum is: " + sum1);

// Task 10: Print elements of an array using foreach loop
Console.WriteLine("\nTask 10: Print elements of an array using foreach loop");
int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();

string[] towns = { "London", "Berlin", "Paris", "Madrid", "Rome" };
foreach (string town in towns)
{
    Console.Write(town + " ");
}
Console.WriteLine();

// Task 11: Print a triangle of numbers
Console.WriteLine("\nTask 11: Print a triangle of numbers");
Console.Write("Enter a number");
int myNum = Convert.ToInt32(Console.ReadLine());

for (int row = 1; row <= myNum; row++)
{
    for (int col = 0; col <= row; col++)
    {
        Console.Write(col + " ");
    }
    Console.WriteLine();
}

// Task 12: Print all prime numbers in a given range
Console.WriteLine("\nTask 12: Print all prime numbers in a given range");
Console.Write("Start from: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.Write("End at: ");
int end = Convert.ToInt32(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    bool prime1 = true;
    int divider1 = 2;
    int maxDivider1 = (int)Math.Sqrt(i);

    while (divider1 <= maxDivider1)
    {
        if (i % divider1 == 0)
        {
            prime1 = false;
            break;
        }
        divider1++;
    }
    if (prime1)
    {
        Console.Write(" " + i);
    }
}

// Task 13: Find all four-digit numbers with the sum of the first two digits equal to the sum of the last two digits
Console.WriteLine("\n\nTask 13: Find all four-digit numbers with the sum of the first two digits equal to the sum of the last two digits");
for (int firstDigit = 1; firstDigit <= 9; firstDigit++)   // i
{
    for (int secondDigit = 0; secondDigit <= 9; secondDigit++)   // j
    {
        int leftSum = firstDigit + secondDigit; // sum of first two digits

        for (int thirdDigit = 0; thirdDigit <= 9; thirdDigit++)  // k
        {
            for (int fourthDigit = 0; fourthDigit <= 9; fourthDigit++) // l
            {
                int rightSum = thirdDigit + fourthDigit;

                // Check if both sums are equal
                if (leftSum == rightSum)
                {
                    Console.WriteLine($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit}");
                }
            }
        }
    }
}

// Task 14: Generate combinations of six numbers from given ranges
// Console.WriteLine("\nTask 14: Generate combinations of six numbers from given ranges");
// for (int i1 = 0; i1 <= 44; i1++)
// {
//     for (int i2 = 0; i2 <= 45; i2++)
//     {
//         for (int i3 = 0; i3 <= 46; i3++)
//         {
//             for (int i4 = 0; i4 <= 47; i4++)
//             {
//                 for (int i5 = 0; i5 <= 48; i5++)
//                 {
//                     for (int i6 = 0; i6 < 0; i6++)
//                     {
//                         Console.WriteLine(i1 + " " + i2 + " " + i3 + " " + i4 + " " + i5 + " " + i6);
//                     }
//                 }
//             }
//         }
//     }
// }