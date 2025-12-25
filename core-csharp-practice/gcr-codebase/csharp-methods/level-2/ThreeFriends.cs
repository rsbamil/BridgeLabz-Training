using System;

class ThreeFriends{
    static void Main(){
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++){
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + ": ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        FindYoungest(names, ages);
        FindTallest(names, heights);
    }

    static void FindYoungest(string[] names, int[] ages){
        int minAge = ages[0];
        int index = 0;

        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < minAge){
                minAge = ages[i];
                index = i;
            }
        }

        Console.WriteLine("\nYoungest Friend is: " + names[index] + " (Age = " + minAge + ")");
    }

    static void FindTallest(string[] names, double[] heights){
        double maxHeight = heights[0];
        int index = 0;

        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > maxHeight){
                maxHeight = heights[i];
                index = i;
            }
        }
        Console.WriteLine("Tallest Friend is: " + names[index] + " (Height = " + maxHeight + ")");
    }
}
