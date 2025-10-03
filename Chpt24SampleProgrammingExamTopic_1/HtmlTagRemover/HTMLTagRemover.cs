using System.Text;
using System.Text.RegularExpressions;

namespace Chpt24SampleProgrammingExamTopic_1;

public class HTMLTagRemover
{
    private const string InputFileName = "./HtmlTagRemover/Problem2.html";
    private const string OutputFileName = "./HtmlTagRemover/Problem1.txt";
    private const string Charset = "utf-8";

    public static void RunHTMLTagRemover()
    {
        if (!File.Exists(InputFileName))
        {
            Console.WriteLine($"File {InputFileName} not found");
            return;
        }

        StreamReader reader = null;
        StreamWriter writer = null;
        try
        {
            Encoding encoding = Encoding.GetEncoding(Charset);
            reader = new StreamReader(InputFileName, encoding);
            writer = new StreamWriter(OutputFileName, false, encoding);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Find what we need
                line = RemoveAllTags(line);
                line = RemoveNewLinesWithWhiteSpace(line);
                line = TrimeNewLines(line);
                if (!string.IsNullOrEmpty(line))
                {
                    writer.WriteLine(line);
                }
            }
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

    /// <summary>Replaces every tag with new line</summary>
    static string RemoveAllTags(string str)
    {
        string textWithoutTags = Regex.Replace(str, "<[^>]*>", "\n");
        return textWithoutTags;
    }

    /// <summary>Replaces sequence of new lines with only one new line</summary>
    static string RemoveNewLinesWithWhiteSpace(string str)
    {
        string pattern = "\n\\s+";
        return Regex.Replace(str, pattern, "\n");
    }

    /// <summary>Removes new lines from start and end string</summary>
    static string TrimeNewLines(string str)
    {
        int start = 0;
        while (start < str.Length && str[start] == '\n')
        {
            start++;
        }

        int end = str.Length - 1;
        while (end >= 0 && str[end] == '\n')
        {
            end--;
        }

        if (start > end)
        {
            return string.Empty;
        }

        string trimmed = str.Substring(start, end - start + 1);
        return trimmed;
    }
}
