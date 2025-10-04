using System;

namespace Chpt25SampleProgrammingExamSampleTopic2.CountingUpperAndLowerCaseWords;

public class CountUpperAndLowerCaseWords
{
    private static char[] ExtractSeparators(string text)
    {
        HashSet<char> separators = new HashSet<char>();
        foreach (char character in text)
        {
            // If the character is not a letter
            // then by definition it is a seperator
            if (!char.IsLetter(character))
            {
                separators.Add(character);
            }
        }
        return separators.ToArray();
    }

    private static string[] ExtractWords(string text)
    {
        char[] separators = ExtractSeparators(text);
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        return words;
    }

    private static bool IsUpperCase(string word)
    {
        bool result = word.Equals(word.ToUpper());
        return result;
    }

    private static bool IsLowerCase(string word)
    {
        bool result = word.Equals(word.ToLower());
        return result;
    }

    private static List<string> GetTestData()
    {
        List<string> testData = new List<string>();
        testData.Add("This is wonderful!!! All separators like " + "these ,.(? and these /* are recognized. It works.");
        testData.Add("SingleWord");
        testData.Add(string.Empty);
        testData.Add(">?!>?#@?");
        return testData;
    }

    private static void CountWords(string[] words)
    {
        int allUpperCaseWordsCount = 0;
        int allLowerCaseWordsCount = 0;
        foreach (string word in words)
        {
            if (IsLowerCase(word))
            {
                allLowerCaseWordsCount++;
            }
            else if (IsUpperCase(word))
            {
                allUpperCaseWordsCount++;
            }
        }
        Console.WriteLine($"Total words count: {words.Length}");
        Console.WriteLine($"Upper case words count: {allUpperCaseWordsCount}");
        Console.WriteLine($"Lower case words count: {allLowerCaseWordsCount}");
    }

    private static string ReadText()
    {
        Console.WriteLine("Enter text:");
        return Console.ReadLine();
    }
    public static void TestCountWords()
    {
        List<string> testData = GetTestData();
        foreach (string testCase in testData)
        {
            Console.WriteLine("Test Case: {0}", testCase);
            Console.WriteLine("Result: ");
            CountWords(ExtractWords(testCase));
            Console.WriteLine();
        }
    }


    public static void TestExtractWords()
    {
        List<string> testData = GetTestData();
        foreach (string testCase in testData)
        {
            Console.WriteLine($"\nTest Case: {testCase}");
            string[] words = ExtractWords(testCase);
            Console.WriteLine("Result: {0}", string.Join(" ", words));
        }
    }
    public static void TestExtractSeparators()
    {
        List<string> testData = GetTestData();
        foreach (string testCase in testData)

        {
            Console.WriteLine($"Test Case: \n {testCase}");
            Console.WriteLine("Result:");
            foreach (char separator in ExtractSeparators(testCase))
            {
                Console.Write("{0} ", separator);
            }
            Console.WriteLine();
        }
    }

    public static void RunExactWordsCounter()
    {
        string text = ReadText();
        string[] words = ExtractWords(text);
        CountWords(words);
    }
}
