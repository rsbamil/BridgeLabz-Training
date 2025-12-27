using System;

class Duplicates
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string ans = "";

        for (int i = 0; i < str.Length; i++)
        {
            bool flag = false;

            for (int j = 0; j < ans.Length; j++)
            {
                if (str[i] == ans[j])
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
                ans += str[i];
        }

        Console.WriteLine("String after removing duplicates: " + ans);
    }
}
