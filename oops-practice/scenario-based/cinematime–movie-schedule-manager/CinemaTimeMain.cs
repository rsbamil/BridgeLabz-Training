using System;
namespace CinemaTime
{
    internal class CinemaTimeMain
    {
        static void Main(string[] args)
        {
            ICinema cinema = new CinemaUtilityImpl();
            CinemaMenu menu = new CinemaMenu(cinema);
            menu.ShowMenu();
        }
    }
}
