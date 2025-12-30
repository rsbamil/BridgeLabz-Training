using System;
class EduQuiz
{
    static string[] correctAns = { "C", "B", "C", "C", "B", "A", "A", "C", "A", "C" };
    static string[] studentAnswers = new string[10];
    static void Main()
    {
        EduQuiz eq = new EduQuiz();
        string[,] questions =
        {
            {"What is the capital of France?", "A. Berlin", "B. Madrid", "C. Paris", "D. Rome", "C"},
            {"What is 2 + 2?", "A. 3", "B. 4", "C. 5", "D. 6", "B"},
            {"What is the largest planet in our solar system?", "A. Earth", "B. Mars", "C. Jupiter", "D. Saturn", "C"},
            {"Who painted the Mona Lisa?", "A. Vincent Van Gogh", "B. Pablo Picasso", "C. Leonardo da Vinci", "D. Claude Monet", "C"},
            {"What is the boiling point of water?", "A. 90°C", "B. 100°C", "C. 110°C", "D. 120°C", "B"},
            {"Who wrote 'To Kill a Mockingbird'?", "A. Harper Lee", "B. Mark Twain", "C. Jane Austen", "D. Charles Dickens", "A"},
            {"What is the chemical symbol for gold?", "A. Au", "B. Ag", "C. Cu", "D. Fe", "A"},
            {"What is the smallest prime number?", "A. 0", "B. 1", "C. 2", "D. 3", "C"},
            {"Who is known as the 'Father of Computers'?", "A. Charles Babbage", "B. Alan Turing", "C. John von Neumann", "D. Steve Jobs", "A"},
            {"What is the hardest natural substance on Earth?", "A. Gold", "B. Iron", "C. Diamond", "D. Platinum", "C"}
        };
        eq.DisplayQuestions(questions);
        int score=eq.CalculateScore(correctAns,studentAnswers);
        eq.DetailedFeedback(correctAns,studentAnswers);
        eq.ShowPercentage(score);
        
    }
    void DisplayQuestions(string[,] questions)
    {
        for (int i = 0; i < questions.GetLength(0); i++)
        {
            Console.WriteLine(i + 1 + ". " + questions[i, 0]);
            for (int j = 1; j <= 4; j++)
            {
                Console.WriteLine("   " + questions[i, j]);
            }
            Console.Write("Enter your answer (A, B, C, or D): ");
            studentAnswers[i] = Console.ReadLine();
        }
    }
    int CalculateScore(string[] correctAns, string[] studentAns)
    {
        int score = 0;
        for (int i = 0; i < correctAns.Length; i++)
        {
            if (correctAns[i].Equals(studentAns[i], StringComparison.OrdinalIgnoreCase))
            {
                score += 10;
            }
        }
        return score;
    }
    void DetailedFeedback(string[] correctAns, string[] studentAns)
    {
        for (int i = 0; i < correctAns.Length; i++)
        {
            if (correctAns[i].Equals(studentAns[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nQuestion {0}: Correct", i + 1);
            }
            else
            {
                Console.WriteLine("\nQuestion {0}: Incorrect.", i + 1);
            }
        }
    }
    void ShowPercentage(int score)
    {
        double percentage = (score / 100.0) * 100;
        Console.WriteLine("\nYour percentage score is: {0}%", percentage);
        if (percentage >= 33)
        {
            Console.WriteLine("\nYou have passed the quiz.");
        }
        else
        {
            Console.WriteLine("\nYou have failed the quiz.");
        }
    }
}
