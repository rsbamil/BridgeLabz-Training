using System;

class NumCheck{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = StoreDigits(number, count);

        Console.WriteLine("\nTotal Digits = " + count);

        Console.WriteLine("Digits are:");
        for (int i = 0; i < digits.Length; i++){
            Console.Write(digits[i] + " ");
        }

        Console.WriteLine("\n\nIs Duck Number? " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number? " + IsArmstrong(number, digits));

        int[] largest = FindLargestTwo(digits);
        int[] smallest = FindSmallestTwo(digits);

        Console.WriteLine("\nLargest = " + largest[0]);
        Console.WriteLine("Second Largest = " + largest[1]);
        Console.WriteLine("Smallest = " + smallest[0]);
        Console.WriteLine("Second Smallest = " + smallest[1]);
    }

    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number = number / 10;
        }
        return count;
    }

    public static int[] StoreDigits(int number, int count)
    {
        int[] digits = new int[count];
        int index = count - 1;

        while (number != 0)
        {
            digits[index] = number % 10;
            number = number / 10;
            index--;
        }
        return digits;
    }

    public static bool IsDuckNumber(int[] digits)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
                return true;
        }
        return false;
    }

    public static bool IsArmstrong(int number, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;

        for (int i = 0; i < digits.Length; i++)
        {
            sum += (int)Math.Pow(digits[i], power);
        }

        return sum == number;
    }

    public static int[] FindLargestTwo(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }
        return new int[] { largest, secondLargest };
    }

    public static int[] FindSmallestTwo(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] < smallest)
            {
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest)
            {
                secondSmallest = digits[i];
            }
        }
        return new int[] { smallest, secondSmallest };
    }
}
