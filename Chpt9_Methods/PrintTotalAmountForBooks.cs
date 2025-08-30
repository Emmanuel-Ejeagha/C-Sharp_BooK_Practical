using System;

namespace Chpt9_Methods;

public class PrintTotalAmountForBooks
{
    // This method calculates and prints the total amount for an array of book prices
    public static void PrintTotalAmount(params decimal[] prices)
    {
        decimal totalAmount = 0;

        foreach (decimal singleBookPrice in prices)
        {
            totalAmount += singleBookPrice;
        }
        Console.WriteLine("The total amount for all books is: $" + totalAmount);
    }
}
