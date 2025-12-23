using System;
class Friends{
    static void Main(){
        string[] names = { "Amar", "Akbar", "Anthony" };
        int [] age=new int[3];
        double [] height=new double[3];

        for (int i = 0; i < 3; i++){

            Console.Write("Age: ");
            age[i]=int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height[i]=double.Parse(Console.ReadLine());
        }

        int youngestIdx=0;
        int tallestIdx=0;

        for(int i=1;i<3;i++){
            if (age[i]<age[youngestIdx]){
                youngestIdx=i;
            }
            if (height[i]>height[tallestIdx]){
                tallestIdx=i;
            }
        }

        Console.WriteLine("Youngest Friend: "+names[youngestIdx]);
        Console.WriteLine("Tallest Friend: "+names[tallestIdx]);
    }
}
