using System;
class NumCheck{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int ans=check(n);
        Console.WriteLine(ans);
    }
    static int check(int n){
        if(n>0){
            return 1;
        }
        else if(n<0){
            return -1;
        }
        return 0;
    }
}