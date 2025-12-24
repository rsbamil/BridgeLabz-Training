using System;
class Choco{
    static void Main(){
        int numberOfChildren=int.Parse(Console.ReadLine());
        int numberOfChocolates =int.Parse(Console.ReadLine());
        int [] result=choco(numberOfChildren,numberOfChocolates);
        Console.WriteLine("Each child gets "+result[0]+" chocolates and "+result[1]+" chocolates are left over");

    }
    public static int[] choco(int n, int m){
        int [] arr=new int[2];
        arr[0]=n/m;
        arr[1]=n%m;
        return arr;
    } 
}