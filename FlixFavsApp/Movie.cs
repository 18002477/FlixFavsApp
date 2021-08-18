using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavsApp
{
    public class Movie
    {
        private string iD;
        private string title;
        private string genre;
        private int year;
        private int ratings;

        public Movie()
        {
        }

        public Movie(string iD, string title, string genre, int year, int ratings)
        {
            ID = iD;
            this.Title = title;
            this.Genre = genre;
            this.Year = year;
            this.Ratings = ratings;
        }

        public string ID { get => iD; set => iD = value; }
        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Year { get => year; set => year = value; }
        public int Ratings { get => ratings; set => ratings = value; }

        public override string ToString()
        {
            return "ID : " + ID + Environment.NewLine + "Movie Title: " + Title + Environment.NewLine + "Genre: " + Genre + Environment.NewLine + "Year: " + Year + Environment.NewLine + "Ratings: " + Ratings;
        }
    }
}
