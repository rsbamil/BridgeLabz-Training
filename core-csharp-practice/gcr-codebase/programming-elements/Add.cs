using System;
class Add
{
  static void Main(){
	Console.WriteLine("Enter First Number");
	int a = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter Second Number");
	int b = Convert.ToInt32(Console.ReadLine());
	int c=a+b;
	Console.WriteLine("Sum ="+c);
	}
}