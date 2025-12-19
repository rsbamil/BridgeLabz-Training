using System;
class DataTypes{
    static void Main(){
        // Primitive Data Types

        // byte 
        byte a = 10; // 1 byte
        Console.WriteLine("a :" + a);

        // short
        short b = 3000; // 2 bytes
        Console.WriteLine("b :" + b);

        // int 
        int c=342567; // 4 bytes
        Console.WriteLine("c :" + c);

        // long
        long d=12345678901234; // 8 bytes
        Console.WriteLine("d :" + d);

        // float
        float e=5.73f; // 4 bytes
        Console.WriteLine("e :" + e);

        // double 
        double f=18.3764386; // 8 bytes
        Console.WriteLine("f :" + f);

        // char
        char g='A'; // 2 bytes
        Console.WriteLine("g :" + g);

        // bool
        bool h=true; // 1 byte
        Console.WriteLine("h :" + h);

        // Non-Primitive Data Types
        // String
        String s="Rohit";
        Console.WriteLine("String: " + s);

        // ************************* Type Casting *****************************
        // Implicit Type Casting
        // byte to int 
        int i=a;
        Console.WriteLine("Implicit Type Casting (byte to int): " + i);

        // int to float
        float z=c;
        Console.WriteLine("Conversion from int to float : "+z.ToString("0.0"));

        // short to long
        long j =b;
        Console.WriteLine("Implicit Type Casting (short to long): " + j);

        // float to double
        double k=e;
        Console.WriteLine("Implicit Type Casting (float to double): " + k);

        // Explicit Type Casting
        // int to byte
        byte l=(byte)c;
        Console.WriteLine("Explicit Type Casting (int to byte): " + l);

        // long to short
        short m=(short)j;
        Console.WriteLine("Explicit Type Casting (long to short): " + m);

        // double to float
        float n=(float)k;
        Console.WriteLine("Explicit Type Casting (double to float): " + n);

    }
}