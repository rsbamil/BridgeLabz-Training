using System;
class SpringSeason{
    static void Main(){
        int month=int.Parse(Console.ReadLine());
        int day=int.Parse(Console.ReadLine());
        check(month,day);
    }
    static void check(int month,int day){
        if((month>=3 || day>=20) && (month<=6 || day<=20)){
            Console.WriteLine("Its a Spring Season");
        }
        else{
            Console.WriteLine("Not a Spring Season");
        }
    }
}