using System;

class NullRef
{
    static void Main()
    {
        DemonstrateNullReference();
    }

    static void DemonstrateNullReference()
    {
        try
        {
            string name = null;  
            int length = name.Length; 

            Console.WriteLine("Length: " + length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Exception Caught: " + ex.Message);
            Console.WriteLine("You tried to use a null object!");
        }
    }
}
