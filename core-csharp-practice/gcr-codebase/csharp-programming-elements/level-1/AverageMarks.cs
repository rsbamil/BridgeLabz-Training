using System;
class AverageMarks{
    static void Main(){
        int physicsMarks=95;
        int mathsMarks=94;
        int chemistryMarks=96;

        double averageMarks=(physicsMarks+mathsMarks+chemistryMarks)/3.0;
        Console.WriteLine("Sam’s average mark in PCM is "+averageMarks);
    }
}