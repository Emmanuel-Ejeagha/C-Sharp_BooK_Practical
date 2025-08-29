using Chpt9_Methods;

// Invoking PrintTotalAmount Method
decimal[] prices = { 19.95m, 25.50m, 8.99m, 12.75m, 5.49m };

PrintTotalAmountForBooks.PrintTotalAmount(prices);


int[] arrArg = { 1, 2, 3 };

Console.Write("Before ModifyArray() the argument is: ");
PassingArgOfRefType.PrintArray(arrArg);

// Modifying the array's argument
PassingArgOfRefType.ModifyArray(arrArg);

Console.Write("After ModifyArray() the argument is: ");
PassingArgOfRefType.PrintArray(arrArg);