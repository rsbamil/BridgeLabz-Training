using System;

class LuckyDraw
{
    static void Main()
    {
        Console.WriteLine("🎉 DIWALI MELA LUCKY DRAW 🎉");
        StartLuckyDraw();
    }

    static void StartLuckyDraw()
    {
        while (true)
        {
            int number = GetVisitorNumber();

            if (number <= 0)
            {
                Console.WriteLine("❌ Invalid number! Try again.");
                continue;   // Skip invalid input
            }

            CheckWinner(number);

            if (!AskToContinue())
                break;
        }
    }

    static int GetVisitorNumber()
    {
        Console.Write("\nEnter your lucky number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void CheckWinner(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Congratulations! You WON a gift!");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next time.");
        }
    }

    static bool AskToContinue()
    {
        Console.Write("Next visitor? (yes/no): ");
        string choice = Console.ReadLine().ToLower();
        return choice == "yes";
    }
}
