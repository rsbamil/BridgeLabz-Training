using System;

class Reverse{
    static void Main(){
        
       int number= int.Parse(Console.ReadLine());
        int count=0;
        int temp = number;
        if(number==0){
            Console.WriteLine("Reversed Number "+0);
            return;
        }
        while(temp!=0){
            count++;
            temp=temp/10;
        }

        int[] digits=new int[count];
        int[] reversedDigits=new int[count];
        temp=number;

        for(int i=0;i<count;i++){
            digits[i]=temp%10;
            temp=temp/10;
        }
        Console.Write("Reversed Number: ");
        for (int i=0;i<count;i++){
            Console.Write(digits[i]);
        }
    }
}
