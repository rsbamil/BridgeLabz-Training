using System;
class SimpleInterest{
    static void Main(){
        int principal=int.Parse(Console.ReadLine());
        int rate=int.Parse(Console.ReadLine());
        int time=int.Parse(Console.ReadLine());
        SI(principal,rate,time);
    }
    static void SI(int p,int r,int t){
        int si=(p*r*t)/100;
        Console.WriteLine("The Simple Interest is "+si+" for Principal "+p+" , Rate of Interest "+r+" and Time "+t);
    }
}