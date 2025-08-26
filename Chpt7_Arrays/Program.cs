// Arrays in C#endregion

int[] myArray = { 1, 2, 3, 4, 5 };
Console.Write("Array elements:");
foreach (int element in myArray)
{
    Console.Write(" " + element);
}
Console.WriteLine();

// Print array value and the default value of uninitialized elements
int[] myArray1 = new int[5];
myArray1[0] = 10;
myArray1[3] = 20;

foreach (int item in myArray1)
{
    Console.Write(" " + item);
}
Console.WriteLine();