using System;
class Digit{
    static void Main(){

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int idx = 0;
        int number=int.Parse(Console.ReadLine());
        while (number != 0){
            digits[idx] = number % 10;   
            number = number / 10;          
            idx++;
            if (idx == maxDigit){
                break;
            }
        }

        int largest = 0;
        int secondLargest = 0;
        
        for (int i = 0; i < idx; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if(digits[i]>secondLargest && digits[i]!=largest){
                secondLargest=digits[i];
            }
        }
        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }
}
