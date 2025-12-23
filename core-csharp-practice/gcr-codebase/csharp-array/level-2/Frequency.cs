using System;
class Frequency{
    static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int count=0;
        while (temp != 0){
            count++;
            temp = temp / 10;
        }

        int[] digits = new int[count];
        int[] frequency = new int[10];
        temp = number;

        for (int i = 0; i < count; i++){
            digits[i] = temp % 10;
            temp = temp / 10;
        }

        for (int i = 0; i < count; i++){
            frequency[digits[i]]++;
        }

        for (int i = 0; i < 10; i++){
            if (frequency[i] > 0){
                Console.WriteLine("Digit " + i + " occurs " + frequency[i] + " times");
            }
        }
    }
}
