using System;

class SnakeLadder
{
    static Random random = new Random();

    static int[] snakeStart = { 99, 70, 52, 25 };
    static int[] snakeEnd = { 54, 55, 42, 2 };

    static int[] ladderStart = { 6, 11, 46, 60 };
    static int[] ladderEnd = { 25, 40, 90, 85 };

    static void Main()
    {
        Console.Write("Enter number of players (2–4): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 2 || n > 4)
        {
            Console.WriteLine("Invalid number of players!");
            return;
        }

        string[] players = new string[n];
        int[] position = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Player " + (i + 1) + " name: ");
            players[i] = Console.ReadLine();
            position[i] = 0;
        }

        bool win = false;

        while (!win)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\n" + players[i] + "'s Turn – Press Enter");
                Console.ReadLine();

                int dice = RollDice();
                int oldPos = position[i];
                int newPos = MovePlayer(oldPos, dice);

                if (newPos > 100)
                {
                    Console.WriteLine(players[i] + " rolled " + dice + ". Turn skipped!");
                    continue;
                }

                newPos = ApplySnakeOrLadder(newPos);

                position[i] = newPos;

                Console.WriteLine(players[i] + " rolled " + dice + ": " + oldPos + " -> " + newPos);


                if (CheckWin(newPos))
                {
                    Console.WriteLine("\n🏆 " + players[i] + " Wins the Game!");
                    win = true;
                    break;
                }
            }
        }
    }

    static int RollDice()
    {
        return random.Next(1, 7);
    }

    static int MovePlayer(int pos, int dice)
    {
        return pos + dice;
    }

    static int ApplySnakeOrLadder(int pos)
    {
        for (int i = 0; i < snakeStart.Length; i++)
        {
            if (pos == snakeStart[i])
            {
                Console.WriteLine("🐍 Snake! Down to " + snakeEnd[i]);
                return snakeEnd[i];
            }
        }

        for (int i = 0; i < ladderStart.Length; i++)
        {
            if (pos == ladderStart[i])
            {
                Console.WriteLine("🪜 Ladder! Up to " + ladderEnd[i]);
                return ladderEnd[i];
            }
        }

        return pos;
    }

    static bool CheckWin(int pos)
    {
        return pos == 100 ? true : false;
    }
}
