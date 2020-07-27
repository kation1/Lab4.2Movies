using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab4._2Movies
{
    class Movie
    {
        private string _title;
        private string _genre;
        public string Title
        {
            get
            {
                return _title;
            }
        }
        public string Genre
        {
            get
            {
                return _genre;

            }
        }
        public Movie(string thetitle, string thegenre)
        {
            _title = thetitle;
            _genre = thegenre;
        }
        public string GetTitle()
        {
            return Title;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Movie newMovie = new Movie("Casino Royale", "Action");
            movies.Add(newMovie);
            movies.Add(newMovie = new Movie ("Die Hard", "Action"));
            movies.Add(newMovie = new Movie("King Kong", "Adventure"));
            movies.Add(newMovie = new Movie("Jurassic Park", "Adventure"));
            movies.Add(newMovie = new Movie("The Lord of the Rings", "Fantasy"));
            movies.Add(newMovie = new Movie("Harry Potter", "Fantatsy"));
            movies.Add(newMovie = new Movie("Psycho", "Horror"));
            movies.Add(newMovie = new Movie("The Shining", "Horror"));
            movies.Add(newMovie = new Movie("Halloween", "Horror"));
            movies.Add(newMovie = new Movie("Spirited Away", "Animated"));

            string userContinue = "on";
            do
            {
                Console.WriteLine("What kind of movie do you want to look at?");
                string userGenre = Console.ReadLine();

                foreach (Movie movie in movies)
                {
                    if (movie.Genre.Contains(userGenre))
                        Console.WriteLine(movie.Title);
                }
                Console.WriteLine("Do you want to continue? Enter 'q' to quit or enter to continue");
               userContinue = Console.ReadLine();
            }
            while (userContinue != "q");

        }
    }
}
