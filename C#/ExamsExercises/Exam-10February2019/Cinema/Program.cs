using System;
using System.Collections.Generic;
using System.Linq;

namespace Cinema
{
    class Movie
    {
        public string MoviesName;
        public decimal Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Movie> projections = new List<Movie>();
            SortedDictionary<string, List<Movie>> moviesProjection = new SortedDictionary<string, List<Movie>>();

            while (input != "Done")
            {
                List<string> data = input.Split(new[] { " <=> ", " : " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string cinema = data[0];
                string movie = data[1];
                decimal price = decimal.Parse(data[2]);

                if (cinema.Contains('-') || cinema.Contains('>') || cinema.Length > 20)
                {
                    Console.WriteLine("Invalid cinema name");
                }

                else if (movie.Contains('-') || movie.Contains('>') || movie.Length > 20)
                {
                    Console.WriteLine("Invalid movie name");
                }
                else
                {
                    Movie currentProjection = new Movie();
                    currentProjection.MoviesName = movie;
                    currentProjection.Price = price;
                    projections.Add(currentProjection);

                    string MoviesAndPrice = movie + ":" + price;

                    if (!moviesProjection.ContainsKey(cinema))
                    {
                        moviesProjection[cinema] = new List<Movie>();
                    }
                    moviesProjection[cinema].Add(currentProjection);
                }

                input = Console.ReadLine();
            }

            foreach (var movie in moviesProjection)
            {
                Console.WriteLine($"- {movie.Key}");

                foreach (var film in movie.Value.OrderByDescending(x => x.Price))
                {
                    Console.WriteLine($"{film.MoviesName} : {film.Price}");
                }
            }
        }
    }
}
