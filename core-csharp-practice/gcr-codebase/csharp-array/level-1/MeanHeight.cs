using System;
class MeanHeight{
    static void Main(){
        double [] heights=new double[11];
        double sum=0;
        for(int i=0;i<heights.Length;i++){
            heights[i]=double.Parse(Console.ReadLine());
            sum+=heights[i];
        }
        double mean=sum/11.0;
        Console.WriteLine("The mean height is "+mean);
    }
}