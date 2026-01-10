using System;
class SortExamScores
{
    static void Main()
    {
        SortExamScores obj = new SortExamScores();
        int[] scores = obj.Input();
        obj.SelectionSort(scores);
    }
    int[] Input()
    {
        Console.WriteLine("ENTER THE NUMBER OF STUDENTS:");
        int numberOfStudents = int.Parse(Console.ReadLine());
        int[] scores = new int[numberOfStudents];
        Console.WriteLine("ENTER THE EXAM SCORES OF THE STUDENTS:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            scores[i] = int.Parse(Console.ReadLine());
        }
        return scores;
    }
    void SelectionSort(int[] scores)
    {
        int n = scores.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIdx])
                {
                    minIdx = j;
                }
            }
            int temp = scores[minIdx];
            scores[minIdx] = scores[i];
            scores[i] = temp;
        }
        Console.WriteLine("SORTED EXAM SCORES IN ASCENDING ORDER :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(scores[i] + " ");
        }
    }
}