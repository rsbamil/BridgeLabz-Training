using System;
class TestScores
{
    static void Main()
    {
        TestScores obj=new TestScores();
        Random r=new Random();  
        Console.WriteLine("ENTER THE NUMBER OF STUDENTS:");
        int students=int.Parse(Console.ReadLine());  // Input number of students
        int [] scores=new int[students];  // Array to hold scores
        // Generating random scores between 0 and 100
        for(int i = 0; i < students; i++)
        {
            scores[i]=r.Next(0,101);
        }
        double average=obj.AverageScore(scores);
        obj.AboveAverageScores(scores,average);
    }
    double AverageScore(int [] scores)
    {
        // Calculating average score
        int sum=0;
        foreach(int score in scores)
        {
            sum+=score;
        }

        double average=(double)sum/scores.Length;
        Console.WriteLine("AVERAGE SCORE: " + average);
        return average;
    }
    void HigestScore(int [] scores)
    {
        // Finding highest score
        int highest=scores[0];
        // Iterating through scores to find the highest
        foreach(int score in scores)
        {
            // Updating highest if current score is greater than highest
            if(score>highest)
            {
                highest=score;
            }
        }
        Console.WriteLine("HIGHEST SCORE: " + highest);
    }
    void LowestScore(int [] scores)
    {
        // Finding lowest score
        int lowest=scores[0];
        // Iterating through scores to find the lowest
        foreach(int score in scores)
        {
            // Updating lowest if current score is less than lowest
            if(score<lowest)
            {
                lowest=score;
            }
        }
        Console.WriteLine("Lowest SCORE: " + lowest);
    }
    void AboveAverageScores(int [] scores,double average)
    {
        // Displaying scores above average
        Console.WriteLine("SCORES ABOVE AVERAGE:");
        foreach(int score in scores)
        {
            // Checking if score is above average
            if(score>average)
            {
                Console.WriteLine(score);
            }
        }
    }
}