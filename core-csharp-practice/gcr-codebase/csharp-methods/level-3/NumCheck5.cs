using System;

class NumberChecker{
    public static int[] GetFactors(int number){
        int count = 0;
        for (int i = 1; i <= number; i++){
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index++] = i;
                }
        }

        return factors;
    }

    public static int GreatestFactor(int[] factors){
        int max = factors[0];
        for (int i = 1; i < factors.Length; i++){
            if (factors[i] > max)
            {
            max = factors[i];
            }
        }
        return max;
    }

    public static int SumOfFactors(int[] factors){
        int sum = 0;
        for (int i = 0; i < factors.Length; i++){
            sum += factors[i];
            }
        return sum;
    }

    public static long ProductOfFactors(int[] factors){
        long product = 1;
        for (int i = 0; i < factors.Length; i++){
            product *= factors[i];
            }
        return product;
    }

    public static double ProductOfCubes(int[] factors){
        double product = 1;
        for (int i = 0; i < factors.Length; i++){
            product *= Math.Pow(factors[i], 3);
            }
        return product;
    }

    public static int ProperDivisorSum(int number){
        int sum = 0;
        for (int i = 1; i < number; i++){
            if (number % i == 0){
                sum += i;
                }
        }
        return sum;
    }

    public static bool IsPerfect(int number){
        return ProperDivisorSum(number) == number;
    }

    public static bool IsAbundant(int number){
        return ProperDivisorSum(number) > number;
    }

    public static bool IsDeficient(int number){
        return ProperDivisorSum(number) < number;
    }

    public static bool IsStrong(int number){
        int temp = number;
        int sum = 0;

        while (temp != 0){
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    public static int Factorial(int n){
        int fact = 1;
        for (int i = 1; i <= n; i++){
            fact *= i;
            }
        return fact;
    }
}

class NumCheck5{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] factors = NumberChecker.GetFactors(number);

        Console.Write("\nFactors: ");
        foreach (int f in factors)
            Console.Write(f + " ");

        Console.WriteLine("\nGreatest Factor: " + NumberChecker.GreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + NumberChecker.SumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + NumberChecker.ProductOfFactors(factors));
        Console.WriteLine("Product of Cubes of Factors: " + NumberChecker.ProductOfCubes(factors));

        Console.WriteLine("\nPerfect Number: " + NumberChecker.IsPerfect(number));
        Console.WriteLine("Abundant Number: " + NumberChecker.IsAbundant(number));
        Console.WriteLine("Deficient Number: " + NumberChecker.IsDeficient(number));
        Console.WriteLine("Strong Number: " + NumberChecker.IsStrong(number));
    }
}
