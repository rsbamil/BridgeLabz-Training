using System;
class SumOfNum{
    static void Main(){
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;
        while (true){
            double input = Convert.ToDouble(Console.ReadLine());
            if (input <= 0){
                break;
            }
            if (index == 10){
                break;
            }
            numbers[index] = input;
            index++;
        }
        for (int i = 0; i < index; i++){
            total += numbers[i];
        }
        Console.WriteLine("Total sum "+total);
    }
}
