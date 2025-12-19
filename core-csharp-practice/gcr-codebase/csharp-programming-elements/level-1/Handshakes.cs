using System;
class Handshakes{
    static void Main(){
        int numberOfStudents =Convert.ToInt32(Console.ReadLine());
        int handshakes=(numberOfStudents*(numberOfStudents-1))/2;
        Console.WriteLine("Total number of handshakes "+handshakes);
    }
}