using System;

class RandomNumbers{
    static void Main(){
        int[] numbers = generateRandom(5);

        Console.WriteLine("Generated 4 digit random numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        double[] result = avgMinMax(numbers);

        Console.WriteLine("\nAverage = " + result[0]);
        Console.WriteLine("Minimum = " + result[1]);
        Console.WriteLine("Maximum = " + result[2]);
    }

    public static int[] generateRandom(int size){
        int[] numbers = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++){
            numbers[i] = rand.Next(1000, 10000);  
        }

        return numbers;
    }

    public static double[] avgMinMax(int[] numbers){
        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++){
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        double average = (double)sum / numbers.Length;

        return new double[] { average, min, max };
    }
}
