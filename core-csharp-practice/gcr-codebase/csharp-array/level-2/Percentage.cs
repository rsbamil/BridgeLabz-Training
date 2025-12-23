using System;

class Percentage{
    static void Main(){
        int n = int.Parse(Console.ReadLine());

        int[] physics = new int[n];
        int[] chemistry = new int[n];
        int[] maths = new int[n];
        double[] percentage = new double[n];
        char[] grade = new char[n];

        for (int i = 0; i < n; i++){
            Console.Write("Marks for Physics: ");
            physics[i] = int.Parse(Console.ReadLine());

            Console.Write("Marks for Chemistry: ");
            chemistry[i] = int.Parse(Console.ReadLine());

            Console.Write("Marks for Maths: ");
            maths[i] = int.Parse(Console.ReadLine());
            if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0){
                Console.WriteLine("Invalid marks! Enter positive values.");
                i--;
            }
        }

        for (int i = 0; i < n; i++){
            percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3.0;
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
            Console.WriteLine("Physics: "+physics[i] + "\t\t" +"Chemistry: "+chemistry[i] + "\t\t" +"Maths: "+maths[i] + "\t" +"Percentage: "+percentage[i] + "\t\t" +"Grade: "+grade[i]);
        }
    }
}
