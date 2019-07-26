using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Cinema_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<Movie>> cinemas = new SortedDictionary<string, List<Movie>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new[] { " <=> ", " : " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "Done")
                {
                    break;
                }

                string cinemaName = input[0];
                string movieName = input[1];
                decimal moviePrice = decimal.Parse(input[2]);

                if (!isValid(cinemaName))
                {
                    Console.WriteLine("Invalid cinema name");
                    continue;
                }
                else if (!isValid(movieName))
                {
                    Console.WriteLine("Invalid movie name");
                    continue;
                }

                if (!cinemas.ContainsKey(cinemaName))
                {
                    cinemas.Add(cinemaName, new List<Movie>());
                }
                Movie currentMovie = new Movie(movieName, moviePrice);
                cinemas[cinemaName].Add(currentMovie);
            }

            foreach (var cinema in cinemas)
            {
                Console.WriteLine($" - {cinema.Key}");

                foreach (Movie m in cinema.Value.OrderByDescending(m => m.Price))
                {
                    Console.WriteLine($"{m.Name} : {m.Price}");
                }
            }
        }

        private static bool isValid(string name)
        {
            if (name.Length > 20 || name.Contains("-") || name.Contains(">"))
            {
                return false;
            }

            return true;
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
