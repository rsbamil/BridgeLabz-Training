using System;
class Bonus{
    static void Main(){
        double salary=double.Parse(Console.ReadLine());
        int year=int.Parse(Console.ReadLine());
        double bonus=0;
        if(year>=5){
            bonus=salary*0.05;
        }
        Console.WriteLine("Bonus: "+bonus);
    }
}