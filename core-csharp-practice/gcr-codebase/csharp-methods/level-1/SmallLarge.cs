using System;
class SmallLarge
{
    public static int[] FindSmallestAndLargest(int number1,int number2,int number3)
    {
        int[] arr=new int[2];
        if(number1<number2 && number1<number3)
            arr[0]=number1;
        else if (number2 < number1 && number2 < number3)
            arr[0] = number2;
        else
            arr[0] = number3;

        if (number1 > number2 && number1 > number3)
            arr[1] = number1;
        else if (number2 > number1 && number2 > number3)
            arr[1] = number2;
        else
            arr[1] = number3;
        return arr;
    }
    static void Main()
    {
        Console.WriteLine("Enter First Number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Third Number");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int[] result = FindSmallestAndLargest(num1,num2,num3);
        Console.WriteLine("The Smallest Number is {0} and Largest Number is {1}",result[0],result[1]);
    }
}