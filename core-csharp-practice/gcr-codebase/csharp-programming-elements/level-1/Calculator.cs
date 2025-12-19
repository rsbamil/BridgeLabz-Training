using System;
class Calculator{
    static void Main(){
        double number1 =Convert.ToDouble(Console.ReadLine());
        double number2=Convert.ToDouble(Console.ReadLine());
        // addition
        double sum=number1 + number2;

        // subtraction
        double sub=number1 - number2;

        // multiplication
        double mul=number1 * number2;

        // division
        double div=number1 / number2;

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+number1+" and "+number2+" is "+sum+", "+sub+", "+mul+", and "+div);

    }
}