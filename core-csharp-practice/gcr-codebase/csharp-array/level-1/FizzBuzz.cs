using System;

class FizzBuzz{
    static void Main(){
        int number = int.Parse(Console.ReadLine());

        if (number <= 0){
            Console.WriteLine("Please enter a positive integer.");
            return;
        }
        string[] arr = new string[number];
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0){
                arr[i - 1] = "FizzBuzz";
            }
            else if (i % 3 == 0){
                arr[i - 1] = "Fizz";
            }
                
            else if (i % 5 == 0){
                arr[i - 1] = "Buzz";
            }
            else{
                arr[i - 1] = i.ToString();
            }
        }
        for (int i = 0; i < arr.Length; i++){
            Console.WriteLine("Position " + (i + 1) + " = " + arr[i]);
        }
    }
}
