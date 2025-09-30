using Chpt21HighQualityProgrammingCode;

if (UnitTest.Sum(new int[] { 1, 2 }) != 3)
    throw new Exception("1 + 2 != 3");

if (UnitTest.Sum(new int[] { 1 }) != 1)
    throw new Exception("Sum of 1 != 1");

if (UnitTest.Sum(new int[] { }) != 0)
    throw new Exception("Sum of 0 numbers != 0");

if (UnitTest.Sum(new int[] { -1, -1 }) != -2)
    throw new Exception("-1 + -1 != -2");

if (UnitTest.Sum(new int[] { 2000000000, 2000000000 }) != 4000000000)
    throw new Exception("200000000 + 200000000 != 4000000000");

// Console.Write("Hello World");