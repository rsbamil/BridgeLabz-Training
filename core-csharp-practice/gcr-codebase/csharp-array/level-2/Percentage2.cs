using System;

class Percentage2{
    static void Main(){
        int n = int.Parse(Console.ReadLine());

        int[,] marks = new int[n, 3];
        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++)        {
            Console.Write("Marks for Physics: ");
            marks[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marks for Chemistry: ");
            marks[i, 1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marks for Maths: ");
            marks[i, 2] = Convert.ToInt32(Console.ReadLine());
            
            if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0){
                Console.WriteLine("Invalid marks! Enter positive values.");
                i--; 
            }
        }

        for (int i = 0; i < n; i++){
            percentage[i] =(marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            if (percentage[i] >= 80){
                grade[i] = 'A';
            }
            else if (percentage[i] >= 70){
                grade[i] = 'B';
            }
            else if (percentage[i] >= 60){
                grade[i] = 'C';
            }
            else if (percentage[i] >= 50){
                grade[i] = 'D';
            }
            else if (percentage[i] >= 40){
                grade[i] = 'E';
            }
            else{
                grade[i] = 'R';
            }
        }

        for (int i = 0; i < n; i++){
            Console.WriteLine("Physics"+marks[i, 0] + "\t\tChemistry: " +marks[i, 1] + "\t\tmaths: " +marks[i, 2] + "\tPercentage: " +percentage[i] + "\t\tGrade: " +grade[i]);
        }
    }
}
