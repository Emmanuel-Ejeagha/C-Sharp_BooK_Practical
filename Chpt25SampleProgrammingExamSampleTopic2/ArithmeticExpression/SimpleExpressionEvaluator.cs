using System;
using System.Linq.Expressions;

namespace Chpt25SampleProgrammingExamSampleTopic2.ArithmeticExpression;

public class SimpleExpressionEvaluator
{
    private static int[] ExtractNumbers(string expression)
    {
        string[] splitResult = expression.Split('-', '+', '*', '/');
        int[] resultNumbers = new int[splitResult.Length];
        for (int i = 0; i < splitResult.Length; i++)
        {
            resultNumbers[i] = int.Parse(splitResult[i].Trim());
        }
        return resultNumbers;
    }

    private static char[] ExtractOperators(string expression)
    {
        string operationCharacters = "+-/*";
        List<char> operators = new List<char>();
        foreach (char c in expression)
        {
            if (operationCharacters.Contains(c))
            {
                operators.Add(c);
            }
        }
        return operators.ToArray();
    }

    private static int CalculateExpression(
        int[] numbers, char[] operators
    )
    {
        List<int> numbersList = new List<int>(numbers);
        List<char> operatorsList = new List<char>(operators);

        for (int i = 0; i < operatorsList.Count; i++)
        {
            if (operatorsList[i] == '*' || operatorsList[i] == '/')
            {
                int left = numbersList[i];
                int right = numbersList[i + 1];
                int result = operatorsList[i] == '*' ? left * right : left / right;

                numbersList[i] = result;
                numbersList.RemoveAt(i + 1);
                operatorsList.RemoveAt(i);
                i--;
            }
        }

        int finalResult = numbersList[0];
        for (int i = 0; i < operatorsList.Count; i++)
        {
            if (operatorsList[i] == '+')
            {
                finalResult += numbersList[i + 1];
            }
            else if (operatorsList[i] == '-')
            {
                finalResult -= numbersList[i + 1];
            }
        }
        return finalResult;
    }

    private static string ReadExpression()
    {
        Console.WriteLine("Enter expression (e.g., 5+10*2-3/2):");
        string expression = Console.ReadLine();
        return expression;
    }

    public static void RunSimpleExpressionEvaluator()
    {
        try
        {
            string expression = ReadExpression();

            int[] numbers = ExtractNumbers(expression);
            char[] operators = ExtractOperators(expression);
            int result = CalculateExpression(numbers, operators);
            Console.WriteLine($"{expression} =  {result}");
        }
        catch (Exception ex)
        {
            if (ex.Message == "Attempted to divide by zero.")
            {
                Console.WriteLine("Error! Cannot divide by zero");
            }
            else
            {

                Console.WriteLine("Invalid Expression: " + ex.Message);
            }
        }
    }
}
