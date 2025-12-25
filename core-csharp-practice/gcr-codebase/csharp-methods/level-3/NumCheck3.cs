using System;

class NumberChecker{
    public static int CountDigits(int number){
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    public static int[] DigitArray(int number){
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--){
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    public static int[] ReverseArray(int[] arr){
        int[] rev = new int[arr.Length];
        int j = 0;

        for (int i = arr.Length - 1; i >= 0; i--){
            rev[j++] = arr[i];
        }
        return rev;
    }

    public static bool CompareArrays(int[] a, int[] b){
        if (a.Length != b.Length)
            return false;

        for (int i = 0; i < a.Length; i++){
            if (a[i] != b[i])
                return false;
        }
        return true;
    }

    public static bool IsPalindrome(int[] digits){
        int[] rev = ReverseArray(digits);
        return CompareArrays(digits, rev);
    }

    public static bool IsDuckNumber(int[] digits){
        foreach (int d in digits){
            if (d != 0)
                return true;
        }
        return false;
    }
}

class NumCheck3{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = NumberChecker.DigitArray(number);

        Console.Write("\nDigits Array: ");
        foreach (int d in digits)
            Console.Write(d + " ");

        int[] reversed = NumberChecker.ReverseArray(digits);

        Console.Write("\nReversed Digits: ");
        for (int i = 0; i < reversed.Length; i++)
            Console.Write(reversed[i] + " ");

        bool same = NumberChecker.CompareArrays(digits, reversed);
        Console.WriteLine("\nArrays are Equal: " + same);

        if (NumberChecker.IsPalindrome(digits)){
            Console.WriteLine("It is a Palindrome Number");
            }
        else{
            Console.WriteLine("It is NOT a Palindrome Number");
            }

        if (NumberChecker.IsDuckNumber(digits)){
            Console.WriteLine("It is a Duck Number");
            }
        else{
            Console.WriteLine("It is NOT a Duck Number");
            }
    }
}
