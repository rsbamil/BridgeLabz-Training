using System;
class Vote{
    static void Main(){
        int [] studentAge=new int[10];
        for(int i=0;i<studentAge.Length;i++){
            studentAge[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<studentAge.Length;i++){
            if(studentAge[i]>=18){
                Console.WriteLine("The student with the age "+studentAge[i]+" can vote.");
            }
            else if(studentAge[i]<0){
                Console.WriteLine("Invalid age");
            }
            else{
                Console.WriteLine("The student with the age "+studentAge[i]+" cannot vote.");
            }
        }
    }
}