using System;
class OutOfRange
{
    static void Main()
    {
        // OutOfRangeDemo();
        HandleOutOfRange();
    }
    static void OutOfRangeDemo()
    {
        string name = "Rohit";
        char ch = name[10];
        System.Console.WriteLine(ch);
    }
    static void HandleOutOfRange()
    {
        try
        {
            string name = "Rohit";
            char ch = name[10];
            System.Console.WriteLine(ch);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
            Console.WriteLine("You tried to access an index outside the string's range!");
        }
    }
}