using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTime
{
    internal class CinemaUtilityImpl:ICinema
    {
        private Movie[] Movies=new Movie[10];
        int count;

        public void AddMovie(string title, string time)
        {
            if (count == Movies.Length)
            {
                Console.WriteLine("No more movies can be added.");
                return;
            }

            Movie movie = new Movie(title);
            string[] times = time.Split(' ');

            for (int i = 0; i < times.Length && i < movie.GetShowTime().Length; i++)
            {
                movie.GetShowTime()[i] = times[i];
            }

            Movies[count++] = movie;
            Console.WriteLine("Movie added successfully!");
        }

        public void DisplayAllMovies()
        {
            foreach (Movie movie in Movies)
            {
                if (movie == null) continue;

                Console.WriteLine("\n----- Movie Details -----");
                Console.WriteLine("Movie Title: " + movie.GetTitle());
                Console.WriteLine("Show Times:");

                foreach (string time in movie.GetShowTime())
                {
                    if (time != null)
                        Console.WriteLine(time);
                }
            }
        }

        public void SearchMovie(string keyword)
        {
            foreach (Movie movie in Movies)
            {
                if (movie != null &&
                    movie.GetTitle().ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine("\n----- Movie Found -----");
                    Console.WriteLine("Movie Title: " + movie.GetTitle());
                    Console.WriteLine("Show Times:");

                    foreach (string time in movie.GetShowTime())
                    {
                        if (time != null)
                            Console.WriteLine(time);
                    }
                }
            }
        }
    }
}
