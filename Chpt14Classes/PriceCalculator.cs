using System;

namespace Chpt14Classes;

public class PriceCalculator
{
    public double CalcPrice(CoffeeSize coffeeSize)
    {
        switch (coffeeSize)
        {
            case CoffeeSize.Small:
                return 0.20;
            case CoffeeSize.Normal:
                return 0.40;
            case CoffeeSize.Double:
                return 0.60;
            default:
                throw new InvalidOperationException("Unsupported coffee quantity: " + (int)coffeeSize);
        }
    }
}
