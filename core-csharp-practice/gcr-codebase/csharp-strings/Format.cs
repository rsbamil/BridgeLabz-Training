using System;

class Format
{
    static void Main()
    {
        TriggerFormatException();
    }

    static void TriggerFormatException()
    {
        try
        {
            string inputText = "Thirty";
            int result = int.Parse(inputText);

            Console.WriteLine("Converted number: " + result);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
            Console.WriteLine("Conversion failed because the input is not a valid number.");
        }
    }
}
