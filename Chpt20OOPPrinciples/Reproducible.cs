using System;

namespace Chpt20OOPPrinciples;

public interface Reproducible<T> where T : Felidae
{
    T[] Reproduce(T mate);
}
