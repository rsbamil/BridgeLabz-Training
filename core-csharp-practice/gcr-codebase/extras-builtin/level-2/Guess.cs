using System;

class Guess
{
    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Press Enter when ready...");
        Console.ReadLine();

        int low = 1, high = 100;
        bool isGuessed = false;

        while (!isGuessed)
        {
            int guess = GenerateGuess(low, high);
            char feedback = GetUserFeedback(guess);
            isGuessed = ProcessFeedback(feedback, ref low, ref high);
        }

        Console.WriteLine("Computer guessed your number successfully!");
    }

    static int GenerateGuess(int low, int high)
    {
        Random rnd = new Random();
        return rnd.Next(low, high + 1);
    }

    static char GetUserFeedback(int guess)
    {
        Console.WriteLine("\nIs your number " + guess + " ?");
        Console.Write("Enter H (High), L (Low), C (Correct): ");
        return Char.ToUpper(Console.ReadKey().KeyChar);
    }

    static bool ProcessFeedback(char feedback, ref int low, ref int high)
    {
        switch (feedback)
        {
            case 'H':
                high = high - 1;
                break;
            case 'L':
                low = low + 1;
                break;
            case 'C':
                return true;
            default:
                Console.WriteLine("\nInvalid input! Try again.");
                break;
        }
        return false;
    }
}
