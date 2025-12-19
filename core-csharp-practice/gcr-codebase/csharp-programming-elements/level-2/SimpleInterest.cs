using System;
class SimpleInterest{
    static void Main(){
        double principal = Convert.ToDouble(Console.ReadLine());

        double rate = Convert.ToDouble(Console.ReadLine());

        int time = Convert.ToInt32(Console.ReadLine());

        double si = (principal  * rate * time) / 100;
        Console.WriteLine("The Simple Interest is "+si+" for Principal "+principal+" , Rate of Interest "+rate+" and Time "+time);
    }
}