using System;

class NumCheck{
    static void Main(){
        int[] nums = new int[5];

        for (int i = 0; i < nums.Length; i++){
            Console.Write("Enter number " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nChecking nums:");

        for (int i = 0; i < nums.Length; i++){
            if (IsPositive(nums[i])){
                if (IsEven(nums[i])){
                    Console.WriteLine(nums[i] + " is Positive and Even");
                }
                else{
                    Console.WriteLine(nums[i] + " is Positive and Odd");
                }
            }
            else{
                Console.WriteLine(nums[i] + " is Negative");
            }
        }

        int ans = Compare(nums[0], nums[nums.Length - 1]);

        Console.WriteLine("\nComparison of first and last number:");

        if (ans == 1){
            Console.WriteLine("First number is Greater than Last number");
        }
        else if (ans == 0){
            Console.WriteLine("First number is Equal to Last number");
        }
        else{
            Console.WriteLine("First number is Less than Last number");
        }
    }

    static bool IsPositive(int n){
        if (n >= 0)
            return true;
        else
            return false;
    }

    static bool IsEven(int n){
        if (n % 2 == 0)
            return true;
        else
            return false;
    }

    static int Compare(int n1, int n2){
        if (n1 > n2)
            return 1;
        else if (n1 == n2)
            return 0;
        else
            return -1;
    }
}
