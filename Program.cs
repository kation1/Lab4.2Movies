using System;
using System.Collections.Generic;


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

        public static void AddMovie(List<Movie> movies)
        {

            Console.WriteLine("What is the name of the movie?");
            string movieName = Console.ReadLine();
            Console.WriteLine("What is the movie's genre?");
            string movieGenre = Console.ReadLine();
            Movie newMovie = new Movie(movieName, movieGenre);
            movies.Add(newMovie);
        }
        public static void GenreList(List<Movie> movies)
        { string genreName = "";
            foreach(Movie title in movies)
            {   if (title._genre != genreName)
                {
                    Console.WriteLine(title._genre);
                    genreName = title._genre;
                }
            
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Movie newMovie = new Movie("Casino Royale", "Action");
            movies.Add(newMovie);
            movies.Add(newMovie = new Movie("Die Hard", "Action"));
            movies.Add(newMovie = new Movie("King Kong", "Adventure"));
            movies.Add(newMovie = new Movie("Jurassic Park", "Adventure"));
            movies.Add(newMovie = new Movie("The Lord of the Rings", "Fantasy"));
            movies.Add(newMovie = new Movie("Harry Potter", "Fantatsy"));
            movies.Add(newMovie = new Movie("Psycho", "Horror"));
            movies.Add(newMovie = new Movie("The Shining", "Horror"));
            movies.Add(newMovie = new Movie("Halloween", "Horror"));
            movies.Add(newMovie = new Movie("Spirited Away", "Animated"));

            string userContinue = "on";
            string userInput = "";
            do
            {
                Console.WriteLine("Do you want to search or add a new movie? (add/search)");
                userInput = Console.ReadLine();
                if (userInput == "add")
                {
                    Movie.AddMovie(movies);
                }
                else if (userInput == "search")
                {

                    Console.WriteLine("What kind of movie do you want to look at?"); 
                    Console.WriteLine($"Currently we have options in these genres");
                    Movie.GenreList(movies);
                    string userGenre = Console.ReadLine();

                    int count = 1;
                    bool itemFound = false;
                    foreach (Movie movie in movies)
                    {

                        if (movie.Genre.Contains(userGenre))
                        {
                            Console.Clear();
                            Console.WriteLine($"List of movies in {userGenre}:");
                            Console.WriteLine(movie.Title);
                            itemFound = true;

                        }
                        else if (count == movies.Count && itemFound == false)
                        {
                            Console.WriteLine($"\nThere were no movies in that genre.\n\n");
                        }
                        count++;
                    }
                }
                Console.WriteLine($"\n\n\n\nDo you want to continue? Enter 'q' to quit or enter to continue");
                userContinue = Console.ReadLine();
            }
            while (userContinue != "q");

        }
    }
}
