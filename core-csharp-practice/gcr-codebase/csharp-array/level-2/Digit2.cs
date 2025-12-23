using System;

class Digit{
    static void Main(){
        
        int maxDigit = 10;
        int index=0;
        int[] digits=new int[maxDigit];

        int number=int.Parse(Console.ReadLine());

        while (number!=0){
            if (index==maxDigit){
                maxDigit=maxDigit + 10;

                int[] temp=new int[maxDigit];

                for (int i=0; i<index;i++){
                    temp[i]=digits[i];
                }

                digits=temp; 
            }
            digits[index]=number % 10;
            number=number/10;
            index++;
        }

        int largest=0;
        int secondLargest=0;

        for (int i=0;i<index;i++){
            if (digits[i]>largest){
                secondLargest=largest;
                largest=digits[i];
            }
            else if (digits[i]>secondLargest && digits[i]!=largest){
                secondLargest=digits[i];
            }
        }
        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }
}
