using System;
class Compare{
    static void Main(){
        string s1=Console.ReadLine();
        string s2=Console.ReadLine();
        bool ans=AreEqual(s1,s2);
        // Checking using custom method
        Console.WriteLine(ans?"Equal":"Not Equal");
        // Checking using built-in method
        Console.WriteLine(s1.Equals(s2)?"Equal":"Not Equal");
    }
    static bool AreEqual(string s1,string s2){
        for(int i=0;i<s1.Length;i++){
            if(s1[i]!=s2[i]){
                return false;
            }
        }
        return true;
    }
}