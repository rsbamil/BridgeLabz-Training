using System;
class Substr{
    static void Main(){
        string s=Console.ReadLine();
        int startIdx=int.Parse(Console.ReadLine());
        int endIdx=int.Parse(Console.ReadLine());
        string ans=CreateSubstring(s,startIdx,endIdx);
        Console.WriteLine("Using method "+ans);
        string ans2=s.Substring(startIdx,endIdx-startIdx);
        if(ans==ans2){
            Console.WriteLine("Both are Equal");
        }
        else{
            Console.WriteLine("Not Equal");
        }
    }
    static string CreateSubstring(string s,int startIdx,int endIdx){
        string result="";
        for(int i=startIdx;i<endIdx;i++){
            result+=s[i];
        }
        return result;
    }
}