using System;

namespace Chpt12Exceptions;

public class ReadFile
{
    public static void ReadFile1(string fileName)
    {
        // Exceptions could be thrown in the code below
        try
        {
            TextReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();
            Console.WriteLine(line);
            reader.Close();
        }
        catch (FileNotFoundException fnfe)
        {
            // Exception hjandler for FileNotFoundException
            // We just inform the user that there is no such file
            Console.WriteLine("The file '{0}' is not found.", fileName);
        }
        catch (IOException ioe)
        {
            // Exception handler for other input/output exceptions
            // We just print the stack trace on the console
            Console.WriteLine(ioe.StackTrace);
        }
    }
}
