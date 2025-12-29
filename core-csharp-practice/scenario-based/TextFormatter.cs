using System;
class TextFormatter
{
    static void Main()
    {
        Console.WriteLine("ENTER A SENTENCE:");
        string sentence=Console.ReadLine(); // Taking sentence input from the user
        string result=FormatSentence(sentence);
        Console.WriteLine("Formatted Sentence: " + result); // FINAL RESULT AFTER FORMATTING 
    }
    static string FormatSentence(string sentence)
    {
        string res= SpaceAfterPunctuation(sentence); // ADDING SPACE AFTER PUNCTUATION MARKS
        res=CapitalAfterPeriod(res); // CAPITALIZING FIRST LETTER AFTER PERIOD , QUESTION MARK , EXCLAMATION MARK
        res=TrimmingSpaces(res); // REMOVING EXTRA SPACES
        return res;
    }
    static string SpaceAfterPunctuation(string sentence)
    {
        string result="";
        for(int i = 0; i < sentence.Length; i++)
        {
            if((sentence[i]=='.' || sentence[i]==',' || sentence[i]=='!' || sentence[i]=='?') && sentence.Length>i+1 && sentence[i+1]!=' ')
            {
                result+=sentence[i]+" ";
            }
            else
            {
                result+=sentence[i];
            }
        }
        return result;
    }
    static string CapitalAfterPeriod(string sentence)
    {
        char [] arr=sentence.ToCharArray(); // CONVERTING STRING TO CHARACTER ARRAY FOR MANIPULATION
        if(arr[0]>='a' && arr[0] <= 'z')
        {
            arr[0]=(char)(arr[0]-32); // CAPITALIZING FIRST LETTER OF THE SENTENCE IF IT IS IN SMALL LETTER
        }

        // CAPITALIZING FIRST LETTER AFTER PERIOD , QUESTION MARK , EXCLAMATION MARK
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i]=='.' || arr[i]=='?' || arr[i] == '!')
            {
                int j=i+1;
                while(j<arr.Length && arr[j]==' ')
                {
                    j++;
                }
                if (j < arr.Length && arr[j]>='a' && arr[j]<='z')
                {
                    arr[j]=(char)(arr[j]-32);
                }
            }
        }
        return new string(arr);
    }
    static string TrimmingSpaces(string sentence)
    {
        // REMOVING EXTRA SPACES BETWEEN WORDS
        char [] arr=sentence.ToCharArray();
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i]==' ' && i+1<arr.Length && arr[i+1]==' ')
            {
                arr[i]='\0';
            }
        }
        return new string(arr);
    }
}