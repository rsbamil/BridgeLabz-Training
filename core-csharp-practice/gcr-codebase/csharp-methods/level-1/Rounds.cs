using System;
class Rounds{
    static void Main(){
        int side1=int.Parse(Console.ReadLine());
        int side2=int.Parse(Console.ReadLine());
        int side3=int.Parse(Console.ReadLine());
        rounds(side1,side2,side3);
    }
    static void rounds(int s1,int s2,int s3){
        int perimeter=s1+s2+s3;
        int rounds=perimeter/5;
        Console.WriteLine("The number of rounds possible are "+rounds);
    }
}