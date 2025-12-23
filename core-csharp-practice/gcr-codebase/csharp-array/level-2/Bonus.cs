using System;

class Bonus{
    static void Main(){
        int size = 10;
        double[] salary = new double[size];
        double[] years = new double[size];
        double[] bonus = new double[size];
        double[] newSalary = new double[size];

        double totalBonus = 0;
        double totalOldSalary = 0;
        double totalNewSalary = 0;

        for (int i=0;i<size;i++){
            Console.WriteLine("Enter details of Employee " + (i + 1));

            Console.Write("Salary: ");
            salary[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Years of Service: ");
            years[i] = Convert.ToDouble(Console.ReadLine());
            if (salary[i] <= 0 || years[i] < 0){
                Console.WriteLine("Invalid input! Enter again.");
                i--; 
            }
        }

        for (int i=0;i<size;i++){
            if (years[i]>5){
                bonus[i]=salary[i]*0.05;
            }
            else{
                bonus[i]=salary[i]*0.02;
            }
            newSalary[i]=salary[i]+bonus[i];
            totalBonus=totalBonus+bonus[i];
            totalOldSalary=totalOldSalary+salary[i];
            totalNewSalary=totalNewSalary+newSalary[i];
        }
        
        Console.WriteLine("Total Old Salary: "+totalOldSalary);
        Console.WriteLine("Total Bonus Paid: "+totalBonus);
        Console.WriteLine("Total New Salary: "+totalNewSalary);
    }
}