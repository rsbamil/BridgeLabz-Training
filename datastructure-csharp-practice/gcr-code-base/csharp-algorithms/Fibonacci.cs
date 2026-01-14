using System;
using System.Diagnostics;

class Fibonacci
{
    static void Main()
    {
        int[] testValues = { 10, 30, 50 };

        foreach (int n in testValues)
        {
            Console.WriteLine("\nFibonacci " + n);

            // Recursive (skip large N to avoid freeze)
            if (n <= 30)
            {
                MeasureTime("Recursive", () =>
                {
                    int result = FibonacciRecursive(n);
                });
            }
            else
            {
                Console.WriteLine("Recursive: Skipped (Exponential Time)");
            }

            // Iterative
            MeasureTime("Iterative", () =>
            {
                int result = FibonacciIterative(n);
            });
        }
    }

    // 🔹 Recursive Fibonacci (O(2^N))
    public static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // 🔹 Iterative Fibonacci (O(N))
    public static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;

        int a = 0, b = 1, sum = 0;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    // 🔹 Time Measurement
    static void MeasureTime(string name, Action action)
    {
        Stopwatch sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine(name + " " + sw.ElapsedMilliseconds + " ms");
    }
}
