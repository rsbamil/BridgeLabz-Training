using System;
class Animal{}
class Dog:Animal{}
class Operators{
    static void Main(){
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        
        // Arithmetic Operators
        // Addition
        Console.WriteLine("Addition of a and b : " + (a + b));

        // Subtraction
        Console.WriteLine("Subtraction of a and b : " + (a - b));

        // Multiplication
        Console.WriteLine("Multiplication of a and b : " + (a * b));

        // Division
        Console.WriteLine("Division of a and b : " + (a / b));

        // Modulus
        Console.WriteLine("Modulus of a and b : " + (a % b));

        // Relational Operators
        // Equal to
        Console.WriteLine("Equal to: " + (a == b));

        // Not equal to
        Console.WriteLine("Not equal to: " + (a != b));

        // Greater than
        Console.WriteLine("Greater than: " + (a > b));

        // Less than
        Console.WriteLine("Less than: " + (a < b));

        // Greater than or equal to
        Console.WriteLine("Greater than or equal to: " + (a >= b));

        // Less than or equal to
        Console.WriteLine("Less than or equal to: " + (a <= b));

        // Logical Operators

        bool c=true;
        bool d=false;

        // Logical AND
        Console.WriteLine("Logical AND: " + (c && d));

        // Logical OR
        Console.WriteLine("Logical OR: " + (c || d));

        // Logical NOT
        Console.WriteLine("Logical NOT: " + (!c));

    //    Assignment Operators
        // Assignment Operator
         int e=10;

        // Addition Assignment
            e += 5; // e = e + 5
            Console.WriteLine("Addition Assignment: " + e);
        
        // Subtraction Assignment
            e -= 3; // e = e - 3    
            Console.WriteLine("Subtraction Assignment: " + e);
        
        // Multiplication Assignment
            e *= 2; // e = e * 2    
            Console.WriteLine("Multiplication Assignment: " + e);
        
        // Division Assignment
            e /= 4; // e = e / 4    
            Console.WriteLine("Division Assignment: " + e);
        
        // Modulus Assignment
            e %= 3; // e = e % 3    
            Console.WriteLine("Modulus Assignment: " + e);
        
        // Unary Operators

        // Unary Plus

        int f=10;
        Console.WriteLine("f :" +f);

        // Unary Minus

        Console.WriteLine("Unary Minus:" +(-f));

        // Increment Operator

        Console.WriteLine("Increament Operator:" +(++f)); // Pre-increment
        Console.WriteLine("Increament Operator:" +(f++)); // Post Increament

        // Decrement Operator
        Console.WriteLine("Decreament Operator:"+(--f)); // Pre-Decreament
        Console.WriteLine("Decreament Operator:"+(f--)); //Post Decreament

        // Logical Compliment

        Console.WriteLine("Logical Compliment:" +(!c));

        // Ternary Operator

        int g=(a>b)?a:b;
        Console.WriteLine("Max is :"+g);


        // is Operator
        Animal animal = new Dog();
        
        Console.WriteLine("animal is Animal : "+(animal is Animal)); //True
        Console.WriteLine("animal is Dog : "+(animal is Dog)); // True
        Console.WriteLine("animal is String : "+(animal is String)); // False
        


    }
}