using System;

class CToF
{
    static void Main(string[] args)
    {
        int cel = Convert.ToInt32(Console.ReadLine());
        int fah = (cel * 9 / 5) + 32;
        Console.WriteLine(fah);
    }
}
