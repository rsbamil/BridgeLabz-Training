using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException()
        : base("Age must be 18 or above")
    {
    }
}

class CustomException
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            ValidateAge(age);

            Console.WriteLine("Age is valid.");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number");
        }
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException();
        }
    }
}
