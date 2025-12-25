using System;

class BMI{
    static void Main(){
        double[,] persons = new double[10, 3];

        for (int i = 0; i < 10; i++){
            Console.Write("\nEnter weight (kg) of person " + (i + 1) + ": ");
            persons[i, 0] = double.Parse(Console.ReadLine());

            Console.Write("Enter height (cm) of person " + (i + 1) + ": ");
            persons[i, 1] = double.Parse(Console.ReadLine());
        }

        CalculateBMI(persons);

        string[] status = GetBMIStatus(persons);

        Console.WriteLine("\nPerson\tWeight\tHeight\tBMI\tStatus");

        for (int i = 0; i < 10; i++){
            Console.WriteLine((i + 1) + "\t" +persons[i, 0] + "\t" +persons[i, 1] + "\t" +persons[i, 2].ToString("0.00") + "\t" +status[i]);
        }
    }

    static void CalculateBMI(double[,] persons){
        for (int i = 0; i < 10; i++){
            double heightInMeter = persons[i, 1] / 100; 
            persons[i, 2] = persons[i, 0] / (heightInMeter * heightInMeter);
        }
    }

    static string[] GetBMIStatus(double[,] persons){
        string[] status = new string[10];

        for (int i = 0; i < 10; i++){
            double bmi = persons[i, 2];

            if (bmi <= 18.4){
                status[i] = "Underweight";
                }
            else if (bmi >= 18.5 && bmi <= 24.9){
                status[i] = "Normal";
                }
            else if (bmi >= 25.0 && bmi <= 39.9){
                status[i] = "Overweight";
                }
            else{
                status[i] = "Obese";
                }
        }
        return status;
    }
}
