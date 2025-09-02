using Chpt11CreatingAndUsingObjects;

// Test the time it takes to execute this code
int startTime = Environment.TickCount;

// Call Cat Methos
Cat.Run();

// System Test
int endTime = Environment.TickCount;
Console.WriteLine("The time elapsed is {0} sec.", (endTime - startTime) / 1000.0);

// Test the time it takes to execute this loop
startTime = Environment.TickCount;

int sum = 0;
for (int i = 0; i <= 10000000; i++)
{
    sum++;
}

endTime = Environment.TickCount;

Console.WriteLine("The time elapsed is {0} sec.", (endTime - startTime) / 1000.0);

// Call PrintRandom Method
RandomNumbers.PrintRandomNumbers();

RandomPasswordGenerator.RandPasswdGen();