using System;
class TwoDim{
    static void Main(){
        int row=int.Parse(Console.ReadLine());
        int col=int.Parse(Console.ReadLine());
        int [,] twoArr=new int [row,col];
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                twoArr[i,j]=int.Parse(Console.ReadLine());
            }
        }
        int [] array=new int [row*col];
        int idx=0;
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                array[idx]=twoArr[i,j];
                idx++;
            }
        }
        Console.WriteLine("The elements in one dimensional array are:");
        for(int i=0;i<array.Length;i++){
            Console.WriteLine(array[i]+" ");
        }
    }
}