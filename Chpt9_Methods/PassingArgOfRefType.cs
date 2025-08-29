namespace Chpt9_Methods;

// Passing Arguments of Reference Type
public class PassingArgOfRefType
{
    // Method to modify the array
    public static void ModifyArray(int[] arrParam)
    {
        arrParam[0] = 9;
        Console.Write("In ModifyingArray() the param is: ");
        PrintArray(arrParam);
    }

    // Helper method to print the array
    public static void PrintArray(int[] arrParam)
    {
        Console.Write("[");
        int length = arrParam.Length;

        if (length > 0)
        {
            Console.Write(arrParam[0].ToString());
            for (int i = 1; i < length; i++)
            {
                Console.Write(", {0}", arrParam[i]);
            }
        }
        Console.WriteLine("]");
    }
}
