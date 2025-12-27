using System;

class ToggleCase
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        char[] arr = str.ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 'A' && arr[i] <= 'Z')
                arr[i] = (char)(arr[i] + 32);
            else if (arr[i] >= 'a' && arr[i] <= 'z')
                arr[i] = (char)(arr[i] - 32);
        }

        Console.WriteLine("Toggled String: " + new string(arr));
    }
}
