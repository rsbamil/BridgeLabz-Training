using System;
class SortStudentMarks
{
    static void Main()
    {
        SortStudentMarks obj = new SortStudentMarks();
        int[] marks = obj.Input();
        obj.BubbleSort(marks);
    }
    int[] Input()
    {
        Console.WriteLine("ENTER THE NUMBER OF SUBJECTS :");
        int subjects = int.Parse(Console.ReadLine());
        int[] marks = new int[subjects];
        Console.WriteLine("ENTER THE MARKS FOR THE SUBJECTS :");
        for (int i = 0; i < subjects; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
        }
        return marks;
    }
    void BubbleSort(int[] marks)
    {
        for (int i = 0; i < marks.Length - 1; i++)
        {
            for (int j = i + 1; j < marks.Length; j++)
            {
                if (marks[i] > marks[j])
                {
                    int temp = marks[i];
                    marks[i] = marks[j];
                    marks[j] = temp;
                }
            }
        }
        Console.WriteLine("SORTED MARKS IN ASCENDING ORDER :");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.Write(marks[i] + " ");
        }
    }
}