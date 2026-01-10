using System;
class SortEmployeeId
{
    static void Main()
    {
        SortEmployeeId obj = new SortEmployeeId();
        int[] id = obj.Input();
        obj.InsertionSort(id);
    }
    int[] Input()
    {
        Console.WriteLine("ENTER THE NUMBER OF Employee ID:");
        int subjects = int.Parse(Console.ReadLine());
        int[] marks = new int[subjects];
        Console.WriteLine("ENTER THE ID:");
        for (int i = 0; i < subjects; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
        }
        return marks;
    }
    void InsertionSort(int[] id)
    {
        int n = id.Length;
        for (int i = 1; i < n; i++)
        {
            int key = id[i];
            int j = i - 1;
            while (j >= 0 && id[j] > key)
            {
                id[j + 1] = id[j];
                j--;
            }
            id[j + 1] = key;
        }
        Console.WriteLine("SORTED EMPLOYEE ID IN ASCENDING ORDER :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(id[i] + " ");
        }
    }
}