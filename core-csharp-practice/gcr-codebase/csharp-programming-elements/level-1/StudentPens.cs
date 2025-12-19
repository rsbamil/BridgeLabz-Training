using System;
class StudentPens{
    static void Main(){
        int pens=14;
        int students=3;
        int penPerStudent=pens/students;
        int remPens=pens%students;
        Console.WriteLine("The Pen Per Student is "+penPerStudent+" and the remaining pen not distributed is "+remPens);
    }
}