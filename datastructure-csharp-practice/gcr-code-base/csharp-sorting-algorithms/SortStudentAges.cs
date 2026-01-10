using System;
class SortStudentAges
{
    static void Main()
    {
        SortStudentAges obj = new SortStudentAges();
        int[] studentAges = obj.Input();
        obj.CountingSort(studentAges);
    }
    int[] Input()
    {
        Console.WriteLine("ENTER THE NUMBER OF STUDENTS:");
        int numberOfStudents = int.Parse(Console.ReadLine());
        int[] ages = new int[numberOfStudents];
        Console.WriteLine("ENTER THE AGES OF THE STUDENTS:");
        for (int i = 0; i < numberOfStudents; i++)
        {
            ages[i] = int.Parse(Console.ReadLine());
        }
        return ages;
    }
    void CountingSort(int[] ages)
    {
        int n = ages.Length;
        int maxAge = 0;
        for (int i = 0; i < n; i++)
        {
            if (ages[i] > maxAge)
            {
                maxAge = ages[i];
            }
        }
        int[] count = new int[maxAge + 1];
        for (int i = 0; i < n; i++)
        {
            count[ages[i]]++;
        }
        int index = 0;
        for (int i = 0; i <= maxAge; i++)
        {
            while (count[i] > 0)
            {
                ages[index++] = i;
                count[i]--;
            }
        }
        Console.WriteLine("SORTED STUDENT AGES IN ASCENDING ORDER :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(ages[i] + " ");
        }
    }
}