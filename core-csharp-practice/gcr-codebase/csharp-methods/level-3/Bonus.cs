using System;

class ZaraUtility{
    public static int[,] GenerateEmployeeData()
    {
        int[,] data = new int[10, 2];   
        Random r = new Random();

        for (int i = 0; i < 10; i++){
            data[i, 0] = r.Next(10000, 100000);
            data[i, 1] = r.Next(1, 11);        
        }
        return data;
    }

    public static double[,] CalculateBonus(int[,] data){
        double[,] result = new double[10, 3]; 

        for (int i = 0; i < 10; i++){
            double oldSalary = data[i, 0];
            int years = data[i, 1];

            double bonus;

            if (years > 5){
                bonus = oldSalary * 0.05;
                }
            else{
                bonus = oldSalary * 0.02;
                }

            double newSalary = oldSalary + bonus;

            result[i, 0] = oldSalary;
            result[i, 1] = bonus;
            result[i, 2] = newSalary;
        }
        return result;
    }

    public static void DisplayTotals(double[,] result){
        double totalOld = 0, totalBonus = 0, totalNew = 0;

        Console.WriteLine("\nEmp\tOldSalary\tBonus\t\tNewSalary");

        for (int i = 0; i < 10; i++){
            Console.WriteLine((i + 1) + "\t" + result[i, 0] + "\t\t" + result[i, 1] + "\t\t" + result[i, 2]);

            totalOld += result[i, 0];
            totalBonus += result[i, 1];
            totalNew += result[i, 2];
        }

        Console.WriteLine("TOTAL\t" + totalOld + "\t\t" + totalBonus + "\t\t" + totalNew);
    }
}

class Bonus{
    static void Main(){
        int[,] employees = ZaraUtility.GenerateEmployeeData();
        double[,] salaryResult = ZaraUtility.CalculateBonus(employees);
        ZaraUtility.DisplayTotals(salaryResult);
    }
}
