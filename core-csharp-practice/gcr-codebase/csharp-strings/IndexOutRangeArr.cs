using System;

class IndexOutRangeArr
{
    static void Main()
    {
        ShowArrayIndexError();
    }

    static void ShowArrayIndexError()
    {
        try
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int value = numbers[7];
            Console.WriteLine("Value = " + value);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
            Console.WriteLine("You tried to access an invalid array index!");
        }
    }
}
