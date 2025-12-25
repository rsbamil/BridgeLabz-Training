using System;

class Roots{
    static void Main(){
        Console.Write("Enter value of a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value of b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value of c: ");
        double c = double.Parse(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);

        if (roots.Length == 0){
            Console.WriteLine("No real roots.");
        }
        else if (roots.Length == 1){
            Console.WriteLine("Only one root: " + roots[0]);
        }
        else{
            Console.WriteLine("Root 1 = " + roots[0]);
            Console.WriteLine("Root 2 = " + roots[1]);
        }
    }

    static double[] FindRoots(double a, double b, double c)
    {
        double d = Math.Pow(b, 2) - (4 * a * c);

        if (d < 0){
            return new double[0];
        }
        else if (d == 0){
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else{
            double r1 = (-b + Math.Sqrt(d)) / (2 * a);
            double r2 = (-b - Math.Sqrt(d)) / (2 * a);
            return new double[] { r1, r2 };
        }
    }
}
