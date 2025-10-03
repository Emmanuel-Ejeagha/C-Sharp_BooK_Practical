static long Fibonacci(int n)
{
    long fn1 = 1;
    long fn2 = 1;
    long fn3 = 1;

    for (int i = 2; i < n; i++)
    {
        fn1 = fn2 + fn3;
        fn3 = fn2;
        fn2 = fn3;
    }
    return fn1;
}

// Recurcive method is very difficult to estimate the complexity:
long Fib(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else if (n == 1)
    {
        return 1;
    }
    else return Fib(n - 1) + Fib(n - 2);
}