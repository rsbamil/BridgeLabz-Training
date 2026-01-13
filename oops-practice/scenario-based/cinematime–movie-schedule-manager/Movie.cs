using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTime
{
    internal class Movie
    {
        private string Title;
        //private string Genre;
        private string[] ShowTime;
        public Movie(string title)
        {
            Title = title;
            ShowTime = new string[3];
        }
        public string GetTitle()
        {
            return Title;
        }
        //public string GetGenre()
        //{
        //    return Genre;
        //}
        public string[] GetShowTime()
        {
            return ShowTime;
        }
        public override string ToString()
        {
            return $"Movie Title: {Title}, Show Times: {string.Join(", ", ShowTime)}";
        }
    }
}
