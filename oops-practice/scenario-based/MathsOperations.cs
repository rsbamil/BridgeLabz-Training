using System;
class MathsOperations
{
    static void Main()
    {
        MathsOperations mathOps = new MathsOperations();
        mathOps.Menu();
    }
    void Menu()
    {

        while (true)
        {
            Console.WriteLine("\nCHOOSE ANY ONE OPTION:");
            Console.WriteLine("1.FACTORIAL OF A NUMBER.\n2.CHECK PRIME NUMBER.\n3.GCD OF TWO NUMBERS.\n4.NTH FIBONACCI NUMBER.\n5.EXIT");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Factorial();
                    break;
                case 2:
                    CheckPrime();
                    break;
                case 3:
                    GCD();
                    break;
                case 4:
                    NthFibonacci();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("INVALID CHOICE");
                    break;
            }
        }
    }
    void Factorial()
    {
        Console.WriteLine("ENTER A NUMBER TO FIND FACTORIAL:");
        int num = int.Parse(Console.ReadLine());
        if(num<0)
        {
            Console.WriteLine("FACTORIAL IS NOT DEFINED FOR NEGATIVE NUMBERS");
            return;
        }
        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("FACTORIAL OF {0} IS {1}", num, factorial);
    }
    void CheckPrime()
    {
        Console.WriteLine("ENTER A NUMBER TO CHECK PRIME:");
        int num = int.Parse(Console.ReadLine());
        if (num <= 1)
        {
            Console.WriteLine("{0} IS NOT A PRIME NUMBER", num);
            return;
        }
        bool isPrime = true;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            Console.WriteLine("{0} IS A PRIME NUMBER", num);
        else
            Console.WriteLine("{0} IS NOT A PRIME NUMBER", num);
    }
    void GCD()
    {
        Console.WriteLine("ENTER TWO NUMBERS TO FIND GCD:");
        Console.Write("FIRST NUMBER: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("SECOND NUMBER: ");
        int num2 = int.Parse(Console.ReadLine());
        int a = num1;
        int b = num2;
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        int gcd = num1;
        Console.WriteLine("GCD OF {0} AND {1} IS {2}", a, b, gcd);
    }
    void NthFibonacci()
    {
        Console.WriteLine("ENTER NUMBER TO FIND NTH FIBONACCI NUMBER:");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1, fib = 0;
        if (n == 0)
            fib = a;
        else if (n == 1)
            fib = b;
        else
        {
            for (int i = 2; i <= n; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
            }
        }
        Console.WriteLine("{0}TH FIBONACCI NUMBER IS {1}", n, fib);
    }
}