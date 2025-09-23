using System;

namespace Chpt15TestFiles;

public class HandlingExceptions
{
    public static void OpenFile()
    {
        string fileName = @"somedir/somefile.txt";
        try
        {
            StreamReader reader = new StreamReader(fileName);
            Console.WriteLine("File {0} successfully opened.", fileName);
            Console.WriteLine("File contents:");
            using (reader)
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can not find file {0}.", fileName);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine(
                "Can not open the file {0}", fileName
            );
        }
    }
}
