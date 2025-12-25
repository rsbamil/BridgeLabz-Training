using System;

class Factors{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = GetFactors(number);

        Console.WriteLine("\nFactors are:");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.WriteLine(factors[i] + " ");
        }

        Console.WriteLine("Sum of factors = " + GetSum(factors));
        Console.WriteLine("Product of factors = " + GetProduct(factors));
        Console.WriteLine("Sum of square of factors = " + GetSumOfSquares(factors));
    }

    static int[] GetFactors(int number){
        int count = 0;

        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    static int GetSum(int[] factors){
        int sum = 0;
        for (int i = 0; i < factors.Length; i++){
            sum += factors[i];
        }
        return sum;
    }

    static int GetProduct(int[] factors){
        int product = 1;
        for (int i = 0; i < factors.Length; i++){
            product *= factors[i];
        }
        return product;
    }

    static double GetSumOfSquares(int[] factors){
        double sum = 0;
        for (int i = 0; i < factors.Length; i++){
            sum += Math.Pow(factors[i], 2);
        }
        return sum;
    }
}
