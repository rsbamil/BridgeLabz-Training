using System;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        long result = Fact(n);

        Console.WriteLine("Factorial of " + n + " is: " + result);
    }

    static long Fact(int n)
    {
        if (n == 0 || n == 1){
            return 1;
        }
        return n * Fact(n - 1);
    }
}
