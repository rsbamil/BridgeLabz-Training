using System;

class BMI{
    static void Main(){

        Console.Write("Enter number of persons: ");
        int n = int.Parse(Console.ReadLine());

        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n;i++){
            Console.Write("Weight (kg): ");

            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height (meters): ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < n; i++){
            bmi[i] = weight[i]/(height[i]*height[i]);

            if (bmi[i] <= 18.4)
                status[i] = "Underweight";
            else if (bmi[i] <= 24.9){
                 status[i] = "Normal";}
            else if (bmi[i] <= 39.9){
                status[i] = "Overweight";
                }
            else{
                status[i] = "Obese";
                }
        }
        for (int i = 0; i < n; i++){
            Console.WriteLine("Height: "+height[i] + "\t" +"Weight: "+ weight[i] + "\t" +"BMI: "+bmi[i] + "\t Status: " +status[i]);
        }
    }
}
