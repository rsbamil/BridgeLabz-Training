using System;
class NaturalNum3{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        int total1=num*(num+1)/2;
        int total2=0;
        for(int i=num;i>=1;i--){
            total2+=i;
        }
        if(total1==total2){
            Console.WriteLine("Total "+total1);
        }
    }
}