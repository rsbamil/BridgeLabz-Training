// 1/01/2026
using System;
using System.Collections.Generic;

class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        string[] arr1 = s1.Split(' ');
        string[] arr2 = s2.Split(' ');

        string[] allWords = new string[arr1.Length + arr2.Length];
        int index = 0;

        for (int i = 0; i < arr1.Length; i++)
            allWords[index++] = arr1[i];

        for (int i = 0; i < arr2.Length; i++)
            allWords[index++] = arr2[i];

        List<string> result = new List<string>();

        for (int i = 0; i < allWords.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < allWords.Length; j++)
            {
                if (allWords[i] == allWords[j])
                    count++;
            }

            if (count == 1)
            {
                bool alreadyAdded = false;
                for (int k = 0; k < result.Count; k++)
                {
                    if (result[k] == allWords[i])
                    {
                        alreadyAdded = true;
                        break;
                    }
                }

                if (!alreadyAdded)
                    result.Add(allWords[i]);
            }
        }

        return result.ToArray();
    }
}
