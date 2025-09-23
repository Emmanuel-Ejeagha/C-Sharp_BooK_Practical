using System;

namespace Chpt12Exceptions;

public class ErrorHandling
{
    /*
    int ReadFile()
    {
        errorCode = 0;
        openFileErrorCode = OpenTheFile();
        // Check whether the file is open
        if (openFileErrorCode == 0)
        {
            while (FileHasMoreLines)
            {
                readLineErrorCode = ReadNextLineFromTheFile();
                if (readLineErrorCode == 0)
                {
                    // Line has been read properly
                    PrintTheLine();
                }
                else
                {
                    // Error during line reading
                    errorCode = -1;
                    break;
                }
            }
            closeFileErrorCode = CloseTheFile();
            if (closeFileErrorCode != 0 && errorCode == 0) Chapter 12.Exception Handling
        441
        {
                errorCode = -2;
            }
else
            {
                errorCode = -3;
            }
        }
        else if (openFileErrorCode == -1)
        {
            // File does not exist
            errorCode = -4;
        }
        else if (openFileErrorCode == -2)
        {
            // File can't be open
            errorCode = -5;
        }
        return errorCode;
    }
    */
}
