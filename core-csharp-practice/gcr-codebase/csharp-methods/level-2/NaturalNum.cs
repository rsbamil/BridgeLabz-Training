using System;

class NaturalNum{
    static void Main(){
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0){
            Console.WriteLine("Please enter a valid natural number.");
            return;
        }

        int recursiveSum = recursion(n);
        int formulaSum = formula(n);

        Console.WriteLine("\nSum using Recursion = " + recursiveSum);
        Console.WriteLine("Sum using Formula = " + formulaSum);

        if (recursiveSum == formulaSum){
            Console.WriteLine("Both results are correct and equal.");
        }
        else{
            Console.WriteLine("Results are NOT equal.");
        }
    }

    static int recursion(int n){
        if (n == 1)
        {
            return 1;
        }
        return n + recursion(n - 1);
    }

    static int formula(int n){
        return n * (n + 1) / 2;
    }
}
