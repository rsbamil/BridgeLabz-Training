using System;

class PrimeNum
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        bool result = IsPrime(num);

        if (result)
            Console.WriteLine(num + " is a Prime Number");
        else
            Console.WriteLine(num + " is NOT a Prime Number");
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
