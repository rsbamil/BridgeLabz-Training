using System;

class NumberChecker{
    public static bool IsPrime(int number){
        if (number <= 1){
            return false;
            }

        for (int i = 2; i <= number / 2; i++){
            if (number % i == 0){
                return false;
                }
        }
        return true;
    }

    public static bool IsNeon(int number){
        int square = number * number;
        int sum = 0;

        while (square != 0){
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }

    public static bool IsSpy(int number){
        int sum = 0, product = 1;

        while (number != 0){
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    public static bool IsAutomorphic(int number){
        int square = number * number;
        int temp = number;

        while (temp != 0){
            if (temp % 10 != square % 10){
                return false;
                }

            temp /= 10;
            square /= 10;
        }
        return true;
    }

    public static bool IsBuzz(int number){
        if (number % 7 == 0 || number % 10 == 7){
            return true;
            }
        else{
            return false;
            }
    }
}

class NumCheck4{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrime Number: " + NumberChecker.IsPrime(number));
        Console.WriteLine("Neon Number: " + NumberChecker.IsNeon(number));
        Console.WriteLine("Spy Number: " + NumberChecker.IsSpy(number));
        Console.WriteLine("Automorphic Number: " + NumberChecker.IsAutomorphic(number));
        Console.WriteLine("Buzz Number: " + NumberChecker.IsBuzz(number));
    }
}
