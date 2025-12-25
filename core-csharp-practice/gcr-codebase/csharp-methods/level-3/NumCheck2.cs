using System;
class NumberChecker{
    public static int CountDigits(int number)
    {
        int count = 0;
        int temp = number;

        while (temp != 0){
            count++;
            temp /= 10;
        }
        return count;
    }

    public static int[] DigitArray(int number){
        int count = CountDigits(number);
        int[] digits = new int[count];
        int temp = number;

        for (int i = count - 1; i >= 0; i--){
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }

    public static int SumOfDigits(int[] digits){
        int sum = 0;
        foreach (int d in digits){
            sum += d;
        }
        return sum;
    }

    public static double SumOfSquares(int[] digits){
        double sum = 0;
        foreach (int d in digits){
            sum += Math.Pow(d, 2);
        }
        return sum;
    }

    public static bool IsHarshad(int number, int[] digits){
        int sum = SumOfDigits(digits);
        return number % sum == 0;
    }

    public static int[,] DigitFrequency(int[] digits){
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
            freq[i, 0] = i;

        foreach (int d in digits)
            freq[d, 1]++;

        return freq;
    }
}

class NumCheck2{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = NumberChecker.CountDigits(number);
        int[] digits = NumberChecker.DigitArray(number);

        Console.WriteLine("\nTotal Digits: " + count);

        Console.Write("Digits Array: ");
        foreach (int d in digits)
            Console.Write(d + " ");

        int sum = NumberChecker.SumOfDigits(digits);
        Console.WriteLine("\nSum of Digits: " + sum);

        double squareSum = NumberChecker.SumOfSquares(digits);
        Console.WriteLine("Sum of Squares of Digits: " + squareSum);

        if (NumberChecker.IsHarshad(number, digits))
            Console.WriteLine("It is a Harshad Number");
        else
            Console.WriteLine("It is NOT a Harshad Number");

        int[,] freq = NumberChecker.DigitFrequency(digits);

        Console.WriteLine("\nDigit Frequency:");
        Console.WriteLine("Digit\tFrequency");
        for (int i = 0; i < 10; i++){
            if (freq[i, 1] > 0)
                Console.WriteLine(freq[i, 0] + "\t" + freq[i, 1]);
        }
    }
}
