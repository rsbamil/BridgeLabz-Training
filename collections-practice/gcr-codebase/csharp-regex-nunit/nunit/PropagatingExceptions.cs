using System;

class PropagatingExceptions
{
    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }

    static void Method1()
    {
        int a = 10;
        int b = 0;
        int x = a / b;
    }

    static void Method2()
    {
        Method1();
    }
}
