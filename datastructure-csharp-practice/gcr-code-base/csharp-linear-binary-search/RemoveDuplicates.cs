using System;
using System.Text;
class RemoveDuplicates
{
    static void Main()
    {
        Console.WriteLine("Enter a string to remove duplicates:");
        string input = Console.ReadLine();
        StringBuilder ans = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (ans.ToString().IndexOf(input[i]) == -1)
            {
                ans.Append(input[i]);
            }
        }
        Console.WriteLine("String after removing duplicates: " + ans.ToString());
    }
}