using System;

class StudentUtility{
    public static int[,] GeneratePCMMarks(int students){
        int[,] pcm = new int[students, 3]; 
        Random r = new Random();

        for (int i = 0; i < students; i++){
            pcm[i, 0] = r.Next(10, 100); 
            pcm[i, 1] = r.Next(10, 100); 
            pcm[i, 2] = r.Next(10, 100); 
        }
        return pcm;
    }

    public static double[,] CalculateResults(int[,] pcm){
        int students = pcm.GetLength(0);
        double[,] result = new double[students, 3]; 

        for (int i = 0; i < students; i++){
            double total = pcm[i, 0] + pcm[i, 1] + pcm[i, 2];
            double avg = total / 3;
            double percent = (total / 300) * 100;

            result[i, 0] = Math.Round(total, 2);
            result[i, 1] = Math.Round(avg, 2);
            result[i, 2] = Math.Round(percent, 2);
        }
        return result;
    }

    public static void DisplayScorecard(int[,] pcm, double[,] result){
        int students = pcm.GetLength(0);

        Console.WriteLine("\nStu\tPhy\tChem\tMath\tTotal\tAvg\tPercent");

        for (int i = 0; i < students; i++){
            Console.WriteLine((i + 1) + "\t" +pcm[i, 0] + "\t" +pcm[i, 1] + "\t" +pcm[i, 2] + "\t" +result[i, 0] + "\t" +result[i, 1] + "\t" +result[i, 2]);
        }
    }
}

class Marks{
    static void Main(){
        Console.Write("Enter Number of Students: ");
        int n = int.Parse(Console.ReadLine());

        int[,] pcm = StudentUtility.GeneratePCMMarks(n);
        double[,] result = StudentUtility.CalculateResults(pcm);
        StudentUtility.DisplayScorecard(pcm, result);
    }
}
