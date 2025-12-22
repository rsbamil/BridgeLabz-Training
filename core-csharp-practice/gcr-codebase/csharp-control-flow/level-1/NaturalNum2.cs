using System;
class NaturalNum2{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        int total1=num*(num+1)/2;
        int total2=0;
        while(num>=1){
            total2+=num;
            num--;
        }
        if(total1==total2){
            Console.WriteLine("Total "+total1);
        }
    }
}