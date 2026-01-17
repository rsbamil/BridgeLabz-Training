using System;
class FitnessTrack
{
    static void Main()
    {
        FitnessTrack obj = new FitnessTrack();
        int[] steps = obj.Input();
        obj.BubbleSort(steps);
        Console.WriteLine("Sorted step counts:");
        foreach (int s in steps)
        {
            Console.Write(s + " ");
        }
    }
    int[] Input()
    {
        Console.WriteLine("Enter the number of people:");
        int n = int.Parse(Console.ReadLine());
        int[] steps = new int[n];
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            steps[i] = rand.Next(1000, 20000);
        }
        return steps;
    }
    void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}