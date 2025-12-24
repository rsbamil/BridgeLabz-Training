using System;
class WindChill{
    static void Main(){
        double temp=double.Parse(Console.ReadLine());
        double windSpeed=double.Parse(Console.ReadLine());
        double ans=CalculateWindChill(temp,windSpeed);
        Console.WriteLine("The Wind Chill is "+ans);
    }
    static double CalculateWindChill(double temp, double windSpeed){
        double windChill = 35.74 + 0.6215 * temp + (0.4275*temp - 35.75) * windSpeed*0.16;
        return windChill;
    }
}