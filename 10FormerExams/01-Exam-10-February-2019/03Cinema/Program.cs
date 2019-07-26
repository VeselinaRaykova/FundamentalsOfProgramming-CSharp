using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cinema> cinemas = new List<Cinema>();

            while (true)
            {
                //there are many time limits if the input is defined outside the while()
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }

                string[] inputLine = input.Split(new[] { " <=> ", " : " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cinemaName = inputLine[0];
                string movieName = inputLine[1];
                decimal moviePrice = decimal.Parse(inputLine[2]);

                if (!IsNameValid(cinemaName))
                {
                    Console.WriteLine("Invalid cinema name");
                    continue;
                }

                if (!IsNameValid(movieName))
                {
                    Console.WriteLine("Invalid movie name");
                    continue;
                }

                Cinema currentCinema = new Cinema(cinemaName);
                Movie currentMovie = new Movie(movieName, moviePrice);

                if (cinemas.All(c => c.Name != cinemaName))
                {
                    cinemas.Add(currentCinema);
                }

                cinemas.First(c => c.Name == cinemaName).Movies.Add(currentMovie);
            }

            foreach (Cinema c in cinemas.OrderBy(c => c.Name))
            {
                Console.WriteLine($" - {c.Name}");
                foreach (Movie m in c.Movies.OrderByDescending(x => x.Price))
                {
                    Console.WriteLine($"{m.Name} : {m.Price}");
                }
            }
        }

        private static bool IsNameValid(string name)
        {
            if (name.Length >= 20 || name.Contains("-") || name.Contains(">"))
            {
                return false;
            }

            return true;
        }
    }

    public class Cinema
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name)
        {
            this.Name = name;
            this.Movies = new List<Movie>();
        }
    }

    public class Movie
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Movie(string movieName, decimal moviePrice)
        {
            this.Name = movieName;
            this.Price = moviePrice;
        }
    }
}
