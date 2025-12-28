using System;

class Fibbo
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Fibo(n);
    }
    static void Fibo(int n)
    {
        int a = 0, b = 1, c;

        Console.WriteLine("\nFibonacci Series:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}
