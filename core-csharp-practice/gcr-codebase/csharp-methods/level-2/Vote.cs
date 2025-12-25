using System;

public class Vote{
    public static bool canVote(int age){
        if (age < 0){
            return false;
        }

        if (age >= 18){
            return true;   
        }
        else{
            return false;   
        }
    }

    static void Main(){
        int [] ages = new int[10];

        for (int i = 0; i < 10; i++){
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            bool ans = canVote(ages[i]);

            if (ans){
                Console.WriteLine("Student " + (i + 1) + " can vote.");
            }
            else{
                Console.WriteLine("Student " + (i + 1) + " cannot vote.");
            }
        }
    }
}
