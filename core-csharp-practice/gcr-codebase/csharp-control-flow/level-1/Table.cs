using System;
class Table{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        if(num>=6 && num<=9){
            for(int i=1;i<=10;i++){
                Console.WriteLine(num + " * "+i+" = "+(num*i));
            }
        }
        else{
            Console.WriteLine("Number is out of range");
        }
    }
}