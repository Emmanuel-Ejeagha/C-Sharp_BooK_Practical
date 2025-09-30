using Chpt22LamdaExpressionAndLINQ;

EvenNumbers.FrindPrimeNumbers();

Dog.GetDogDetails();
Dog.SortedDogs();

List<int> list = new List<int>() { 20, 1, 4, 8, 9, 44 };
//  Process each argument with code statements
var EvenNum = list.FindAll((i) =>
{
    Console.WriteLine($"Value of i is: {i}");
    return (i % 2) == 0;
});

Func<bool> boolFunc = () => true;
Func<int, bool> intFunc = (x) => x < 10;
if (boolFunc() && intFunc(5))
{
    Console.WriteLine("5 < 10");
}

LINQQueryPlayground.PrintNumbers();
LINQQueryPlayground.PrintSortedElements();
LINQQueryPlayground.NumberGrouping();
JoinData.PrintJoinedData();