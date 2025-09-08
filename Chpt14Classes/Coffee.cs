using System;

namespace Chpt14Classes;

public class Coffee
{
    public CoffeeSize size;
    public Coffee(CoffeeSize size)
    {
        this.size = size;
    }

    public CoffeeSize Size
    {
        get { return size; }
    }
}
