using System;

namespace Chpt25SampleProgrammingExamSampleTopic2.CountingUpperAndLowerCaseWords;

public class ArithmeticExpression
{
    private static int[] ExtractNumbers(string expression)
    {
        string[] splitResult = expression.Split('+', '-');
        int[] resultNumbers = new int[splitResult.Length];
        for (int i = 0; i < splitResult.Length; i++)
        {
            resultNumbers[i] = int.Parse(splitResult[i]);
        }
        return resultNumbers;
    }

    private static char[] ExtractOperators(string expression)
    {
        string operatorCharacters = "-+";
        List<char> operators = new List<char>();
        foreach (char c in expression)
        {
            if (operatorCharacters.Contains(c))
            {
                operators.Add(c);
            }
        }
        return operators.ToArray();
    }

    private static int CalculateExpression(int[] numbers, char[] operators)
    {
        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            char operation = operators[i - 1];
            int nextNumber = numbers[i];
            if (operation == '+')
            {
                result += nextNumber;
            }
            else if (operation == '-')
            {
                result -= nextNumber;
            }
        }
        return result;
    }

    private static string ReadExpression()
    {
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();
        return expression;
    }

    public static void RunArithmeticExpression()
    {
        string expression = ReadExpression();
        int[] numbers = ExtractNumbers(expression);
        char[] operators = ExtractOperators(expression);

        int result = CalculateExpression(numbers, operators);
        Console.WriteLine($"{expression} = {result}");
    }

    public static void TestCalculateExpression()
    {
        int[] numbers = new int[] { 1, 2, 3, 4 };
        char[] operators = new char[] { '+', '-', '+' };
        int result = CalculateExpression(numbers, operators);
        Console.WriteLine(result);
    }
    public static void TestExtractNumbers()
    {
        int[] numbers = ExtractNumbers("1+2+4+5-3-6-3+50");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    public static void TestExtractOperators()
    {
        char[] operators = ExtractOperators("2+3+5-4+2+7-9-3");
        foreach (char oper in operators)
        {
            Console.Write($"{oper} ");
        }
        Console.WriteLine();
    }


}
