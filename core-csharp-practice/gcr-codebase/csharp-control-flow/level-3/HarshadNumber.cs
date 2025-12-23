using System;
class HarshadNumber{
    static void Main(){
        int number=int.Parse(Console.ReadLine());
        int sum=0;
        int original=number;
        while(number>0){
            int digit=number%10;
            sum+=digit;
            number/=10;
        }
        if(original%sum==0){
            Console.WriteLine("Harshad Number");
        }
        else{
            Console.WriteLine("Not a Harshad Number");
        }
    }
}