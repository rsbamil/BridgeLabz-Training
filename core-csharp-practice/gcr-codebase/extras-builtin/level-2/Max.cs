using System;

class Max
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int max = FindMaximum(a, b, c);

        Console.WriteLine("\nMaximum number is: " + max);
    }
    static int FindMaximum(int x, int y, int z)
    {
        int max = x;

        if (y > max)
            max = y;

        if (z > max)
            max = z;

        return max;
    }
}
