using System;
class OddEven{
    static void Main(){
        int number=int.Parse(Console.ReadLine());
        if(number<=0){
            Console.WriteLine("Invalid Input");
            return;
        }
        int [] evenArr=new int[(number/2)+1];
        int [] oddArr=new int[(number/2)+1];
        int evenIdx=0;
        int oddIdx=0;
        for(int i=1;i<=number;i++){
            if(i%2==0){
                evenArr[evenIdx]=i;
                evenIdx++;
            }
            else{
                oddArr[oddIdx]=i;
                oddIdx++;
            }
        }
        Console.WriteLine("Even numbers:");
        for(int i=0;i<evenArr.Length;i++){
            Console.Write(evenArr[i]+" ");
        }
        Console.WriteLine("\nOdd numbers:");
        for(int i=0;i<oddArr.Length;i++){
            Console.Write(oddArr[i]+" ");
        }
        }
    }