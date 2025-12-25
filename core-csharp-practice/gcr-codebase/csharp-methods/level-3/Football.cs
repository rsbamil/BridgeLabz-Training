using System;

class Football{
    static void Main(){
        int[] heights = new int[11];
        Random rand = new Random();

        for (int i = 0; i < heights.Length; i++){
            heights[i] = rand.Next(150, 251);
        }

        Console.WriteLine("Heights of Players:");
        for (int i = 0; i < heights.Length; i++){
            Console.WriteLine("Player " + (i + 1) + ": " + heights[i] + " cm");
        }

        int sum = FindSum(heights);
        double mean = FindMean(sum, heights.Length);
        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);

        Console.WriteLine("\nSum of Heights = " + sum);
        Console.WriteLine("Mean Height = " + mean);
        Console.WriteLine("Shortest Height = " + shortest);
        Console.WriteLine("Tallest Height = " + tallest);
    }

    static int FindSum(int[] heights){
        int sum = 0;
        for (int i = 0; i < heights.Length; i++){
            sum += heights[i];
        }
        return sum;
    }

    static double FindMean(int sum, int count){
        return (double)sum / count;
    }

    static int FindShortest(int[] heights){
        int min = heights[0];
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] < min){
                min = heights[i];
            }
        }
        return min;
    }

    static int FindTallest(int[] heights){
        int max = heights[0];
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > max){
                max = heights[i];
            }
        }
        return max;
    }
}
