using System;

class ArgumentOutOfRange
{
    static void Main()
    {
        ShowArgumentOutOfRange();
    }

    static void ShowArgumentOutOfRange()
    {
        try
        {
            string message = "Welcome";
            string part = message.Substring(10, 3); 
            Console.WriteLine("Substring: " + part);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
            Console.WriteLine("Start index is beyond the string length!");
        }
    }
}
