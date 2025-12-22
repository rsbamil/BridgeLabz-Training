using System;
class OddEven{
    static void Main(){
        int num=int.Parse(Console.ReadLine());
        for(int i=1;i<=num;i++){
            if(i%2==0){
                Console.WriteLine(i+" is Even");
            }
            else{
                Console.WriteLine(i+" is Odd");
            }
        }
    }
}