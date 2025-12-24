using System;
class QuoRem{
    static void Main(){
        int number=int.Parse(Console.ReadLine());
        int divisor=int.Parse(Console.ReadLine());
        int[] result=FindRemainderAndQuotient(number,divisor);
        Console.WriteLine("Remainder: "+result[0]+" , Quotient: "+result[1]);
    }
    public static int[] FindRemainderAndQuotient(int number, int divisor){
        int [] arr=new int[2];
        arr[0]=number%divisor;
        arr[1]=number/divisor;
        return arr;
    }
}