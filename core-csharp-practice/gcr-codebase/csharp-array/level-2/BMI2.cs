using System;

class BMI2{
    static void Main(){
        Console.Write("Enter number of persons: ");
       int number = int.Parse(Console.ReadLine());

        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++){
            personData[i] = new double[3];
        }
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("\nEnter details for Person " + (i + 1));

            Console.Write("Weight (kg): ");
            personData[i][0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Height (meters): ");
            personData[i][1] = Convert.ToDouble(Console.ReadLine());
            if (personData[i][0] <= 0 || personData[i][1] <= 0){
                Console.WriteLine("Invalid input! Enter positive values.");
                i--;  
            }
        }

        for (int i = 0; i < number; i++){
            personData[i][2] =
                personData[i][0] /
                (personData[i][1] * personData[i][1]);

            if (personData[i][2] <= 18.4){
                weightStatus[i] = "Underweight";
                }
            else if (personData[i][2] <= 24.9){
                weightStatus[i] = "Normal";
                }
            else if (personData[i][2] <= 39.9){
                weightStatus[i] = "Overweight";
                }
            else{
                weightStatus[i] = "Obese";
                }
        }
        for (int i = 0; i < number; i++){
            Console.WriteLine(personData[i][1] + "\t" +personData[i][0] + "\t" +personData[i][2] + "\t" +weightStatus[i]);
        }
    }
}
