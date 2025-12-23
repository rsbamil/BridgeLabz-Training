using System;
class BMI{
    static void Main(){
        double weight=double.Parse(Console.ReadLine());
        double height=double.Parse(Console.ReadLine());
        double HM=height/100;
        double bmi=weight/(HM*HM);
        if(bmi<=18.5){
            Console.WriteLine("Underweight");
        }
        else if(bmi>18.5 && bmi<=24.9){
            Console.WriteLine("Normal weight");
        }
        else if(bmi>=25 && bmi<=39){
            Console.WriteLine("Overweight");
        }
        else{
            Console.WriteLine("Obese");
        }
    }
}