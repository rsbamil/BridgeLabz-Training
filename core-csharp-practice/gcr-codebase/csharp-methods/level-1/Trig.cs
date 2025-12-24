using System;
class Trig{
    static double[] CalculateTrigonometricFunctions(double angle){
        double radianAngle = (Math.PI / 180.0) * angle;
        double [] result = new double[3];
        result[0] = Math.Sin(radianAngle);
        result[1] = Math.Cos(radianAngle);
        result[2] = Math.Tan(radianAngle);
        return result;
    }
    static void Main(){
        Console.Write("Enter the Angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] result = CalculateTrigonometricFunctions(angle);
        Console.WriteLine("The Sine, Cosine and Tangent of {0} degrees are {1}, {2} and {3}", angle, result[0], result[1], result[2]);
    }
}