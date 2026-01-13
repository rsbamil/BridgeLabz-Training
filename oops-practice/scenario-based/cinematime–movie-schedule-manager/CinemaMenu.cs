using System;

namespace CinemaTime
{
    internal class CinemaMenu
    {
        private ICinema cinema;

        public CinemaMenu(ICinema cinema)
        {
            this.cinema = cinema;
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n====== CINEMA TIME MENU ======");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Display All Movies");
                Console.WriteLine("3. Search Movie");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Movie Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Show Times (space separated): ");
                        string times = Console.ReadLine();

                        cinema.AddMovie(title, times); 
                        break;

                    case 2:
                        cinema.DisplayAllMovies(); 
                        break;

                    case 3:
                        Console.Write("Enter keyword to search: ");
                        string keyword = Console.ReadLine();

                        cinema.SearchMovie(keyword); 
                        break;

                    case 4:
                        Console.WriteLine("Exiting Cinema Time...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
