// Arrays in C#endregion

// Task 1: Declare and initialize an array
using Chpt7_Arrays;

int[] myArray = { 1, 2, 3, 4, 5 };
Console.Write("Array elements:");
foreach (int element in myArray)
{
    Console.Write(" " + element);
}
Console.WriteLine();

// Task:2 Print array value and the default value of uninitialized elements
int[] myArray1 = new int[5];
myArray1[0] = 10;
myArray1[3] = 20;

foreach (int item in myArray1)
{
    Console.Write(item + " ");
}
Console.WriteLine();

// Reverse an array
int[] arrayToReverse = { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18 };
//  Get array length
int length = arrayToReverse.Length;
// Create a new array to hold the reversed values
int[] reversedArray = new int[length];

// Reverse the array
for (int index = 0; index < length; index++)
{
    reversedArray[length - index - 1] = arrayToReverse[index];
}
// Print the reversed array
for (int index = 0; index < length; index++)
{
    Console.Write(reversedArray[index] + " ");
}
Console.WriteLine();

// Task 3: Take user input for an array - 1D array(vector)
Console.Write("Enter the number of elements in the array: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

Console.Write("Array elements:");
foreach (int element in arr)
{
    Console.Write(" " + element);
}
Console.WriteLine();

//Task 4: 2D array
Console.WriteLine("2D array");
int[,] matrix = {
    {1, 2, 3, 6},
    {3, 6, 1, 4},
};

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}

// Task 5: Take user input for a 2D array
Console.WriteLine("Enter the dimensions of the matrix:");
Console.Write("Enter the number of rows: ");
int myRows = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int myCols = int.Parse(Console.ReadLine());

int[,] newMatrix = new int[myRows, myCols];

Console.WriteLine("Enter the elements of the matrix row by row, with elements separated by spaces:");

for (int row = 0; row < myRows; row++)
{
    for (int col = 0; col < myCols; col++)
    {
        Console.Write("matrix[{0},{1}] = ", row, col);
        newMatrix[row, col] = int.Parse(Console.ReadLine());
    }
}

for (int row = 0; row < newMatrix.GetLength(0); row++)
{
    for (int col = 0; col < newMatrix.GetLength(1); col++)
    {
        Console.Write(" " + newMatrix[row, col]);
    }
    Console.WriteLine();
}

// Task 6: Find the maximal sum platform of size 2x2 in a matrix
Console.WriteLine("Find the maximal sum platform of size 2x2 in a matrix");
int[,] matrix2 = {
    { 0, 2, 4, 0, 9, 5 },
    { 7, 1, 3, 3, 2, 1 },
    { 1, 3, 9, 8, 5, 6 },
    { 4, 6, 7, 9, 1, 0 }
};

// Find the maximal sum platform of sixe 2x2 in a matrix
long bestSum = long.MinValue;
int bestRow = 0;
int bestCol = 0;

for (int row = 0; row < matrix2.GetLength(0) - 1; row++)
{
    for (int col = 0; col < matrix2.GetLength(1) - 1; col++)
    {
        long sum = matrix2[row, col] + matrix2[row, col + 1] + matrix2[row + 1, col] + matrix2[row + 1, col + 1];
        if (sum > bestSum)
        {
            bestSum = sum;
            bestRow = row;
            bestCol = col;
        }
    }
}
// Print the result
Console.WriteLine("The best platform is:");
Console.WriteLine(" {0} {1}", matrix2[bestRow, bestCol], matrix2[bestRow, bestCol + 1]);
Console.WriteLine(" {0} {1}", matrix2[bestRow + 1, bestCol], matrix2[bestRow + 1, bestCol + 1]);
Console.WriteLine("The maximal sum is: " + bestSum);


PascalTriangle pascal = new PascalTriangle();
pascal.Print();

// Task 7
int[] arrays = new int[20];

for (int i = 0; i < arrays.Length; i++)
{
    arrays[i] = i * 5;
}

Console.WriteLine("Array elements:");
foreach (var item in arrays)
{
    Console.Write(" " + item);
}
Console.WriteLine();