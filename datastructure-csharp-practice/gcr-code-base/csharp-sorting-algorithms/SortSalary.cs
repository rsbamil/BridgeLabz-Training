using System;
class SortSalary
{
    static void Main()
    {
        SortSalary obj = new SortSalary();
        int[] salaries = obj.Input();
        obj.HeapSort(salaries);
    }
    int[] Input()
    {
        Console.WriteLine("ENTER THE NUMBER OF EMPLOYEES:");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        int[] salaries = new int[numberOfEmployees];
        Console.WriteLine("ENTER THE SALARIES OF THE EMPLOYEES:");
        for (int i = 0; i < numberOfEmployees; i++)
        {
            salaries[i] = int.Parse(Console.ReadLine());
        }
        return salaries;
    }
    void HeapSort(int[] salaries)
    {
        int n = salaries.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }
        for (int i = n - 1; i >= 0; i--)
        {
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;
            Heapify(salaries, i, 0);
        }
        Console.WriteLine("SORTED SALARIES IN ASCENDING ORDER :");
        for (int i = 0; i < n; i++)
        {
            Console.Write(salaries[i] + " ");
        }
    }
    void Heapify(int[] salaries, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && salaries[left] > salaries[largest])
        {
            largest = left;
        }
        if (right < n && salaries[right] > salaries[largest])
        {
            largest = right;
        }
        if (largest != i)
        {
            int swap = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = swap;
            Heapify(salaries, n, largest);
        }
    }
}