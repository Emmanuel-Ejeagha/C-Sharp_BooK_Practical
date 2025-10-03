using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Chpt24SampleProgrammingExamTopic_1;

public class SimpleHtmlTagRemover
{
    private const string InputFileName = "./HtmlTagRemover/Problem1.html";
    private const string OutputFileName = "./HtmlTagRemover/Problem2.txt";
    private const string Charset = "utf-8";
    private static Regex regexWhitespace = new Regex("\n\\s+");

    public static void RunSimpleHtmlTagRemover()
    {
        if (!File.Exists(InputFileName))
        {
            Console.WriteLine($"File {InputFileName} not found.");
            return;
        }

        StreamReader reader = null;
        StreamWriter writer = null;
        try
        {
            Encoding encoding = Encoding.GetEncoding(Charset);
            reader = new StreamReader(InputFileName, encoding);
            writer = new StreamWriter(OutputFileName, false, encoding);
            RemoveHtmlTags(reader, writer);
        }
        catch (IOException)
        {
            Console.WriteLine($"Cannot read file {InputFileName}.");
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
            }
            if (writer != null)
            {
                writer.Close();
            }
        }
    }

    /// <summary>Removes the tags from a HTML text</summary>
    /// <param name="reader">Input trxt</param>
    /// <param name="writer">Output text (result</param>
    static void RemoveHtmlTags(
        StreamReader reader, StreamWriter writer)
    {
        int openTags = 0;
        StringBuilder buffer = new StringBuilder();
        while (true)
        {
            int nextChar = reader.Read();
            if (nextChar == -1)
            {
                // End of file reached
                PrintBuffer(writer, buffer);
                break;
            }
            char ch = (char)nextChar;
            if (ch == '<')
            {
                if (openTags == 0)
                {
                    PrintBuffer(writer, buffer);
                    buffer.Length = 0;
                }
                openTags++;
            }
            else if (ch == '>')
            {
                openTags--;
            }
            else
            {
                // We have other character (not "<" or ">")
                if (openTags == 0)
                {
                    buffer.Append(ch);
                }
            }
        }
    }

    /// <summary>Removes the whitespace and prints the buffer in a file</summary>
    /// <param name="writer">the result file</param>
    /// <param name="buffer">the input for processing</param>
    static void PrintBuffer(
        StreamWriter writer, StringBuilder buffer)
    {
        string str = buffer.ToString();
        string trimmed = str.Trim();
        string textOnly = regexWhitespace.Replace(trimmed, "\n");
        if (!string.IsNullOrEmpty(textOnly))
        {
            writer.WriteLine(textOnly);
        }
    }
}
