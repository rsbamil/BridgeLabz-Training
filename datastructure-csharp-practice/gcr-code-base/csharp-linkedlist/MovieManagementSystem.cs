using System;

// Movie node with previous and next reference
class MovieNode
{
    public string Title;
    public double Rating;
    public MovieNode Prev;
    public MovieNode Next;

    public MovieNode(string title, double rating)
    {
        Title = title;
        Rating = rating;
        Prev = Next = null;
    }
}

class MovieList
{
    private MovieNode head = null;
    private MovieNode tail = null;

    // Add movie at the end
    public void AddMovie(string title, double rating)
    {
        MovieNode node = new MovieNode(title, rating);

        if (head == null)
        {
            head = tail = node;
            return;
        }

        tail.Next = node;
        node.Prev = tail;
        tail = node;
    }

    // Display movies forward
    public void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(string.Format("{0} - {1}", temp.Title, temp.Rating));
            temp = temp.Next;
        }
    }
}

class MovieManagementSystem
{
    static void Main()
    {
        MovieList movies = new MovieList();

        movies.AddMovie("Inception", 9.0);
        movies.AddMovie("Interstellar", 8.8);

        movies.DisplayForward();
    }
}