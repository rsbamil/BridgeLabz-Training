using System;

class Calc
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("\nChoose Operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Result = " + Add(a, b));
                break;
            case 2:
                Console.WriteLine("Result = " + Subtract(a, b));
                break;
            case 3:
                Console.WriteLine("Result = " + Multiply(a, b));
                break;
            case 4:
                Console.WriteLine("Result = " + Divide(a, b));
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    }

    static double Add(double x, double y)
    {
        return x + y;
    }

    static double Subtract(double x, double y)
    {
        return x - y;
    }

    static double Multiply(double x, double y)
    {
        return x * y;
    }

    static double Divide(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Cannot divide by zero!");
            return 0;
        }
        return x / y;
    }
}
