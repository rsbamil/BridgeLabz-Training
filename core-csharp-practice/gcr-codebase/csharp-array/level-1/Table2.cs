using System;
class Table2{
    static void Main(){
        int number=int.Parse(Console.ReadLine());
        int [] table=new int [10];
        if(number>=6 && number<=9){
            for(int i=0;i<table.Length;i++){
            table[i]=number*(i+1);
        }
        for(int i=0;i<table.Length;i++){
            Console.WriteLine(number+" * "+ (i+1) +" = "+table[i]);
            }
        }
        else{
            Console.WriteLine("Number out of range");
        }
    }
}