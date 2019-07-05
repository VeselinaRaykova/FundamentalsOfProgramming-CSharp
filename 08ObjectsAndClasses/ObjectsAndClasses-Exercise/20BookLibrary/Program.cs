using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Library books = new Library();
            Dictionary<string, double> totalPrices = new Dictionary<string, double>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                DateTime date = DateTime.ParseExact(input[3], "dd.MM.yyyy", null);
                Book book = new Book(
                    Title: input[0],
                    Author: input[1],
                    Publisher: input[2],
                    ReleaseDate: DateTime.ParseExact(input[3], "dd.MM.yyyy", null),
                    ISBN: input[4],
                    Price: double.Parse(input[5])
                    );
                books.ListOfBooks.Add(book);
            }

            totalPrices = CalcTotalPrices(books.ListOfBooks);
            var orderedPrices = totalPrices.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var price in orderedPrices)
            {
                Console.WriteLine($"{price.Key} -> {price.Value:f2}");
            }
        }
        private static Dictionary<string, double> CalcTotalPrices(List<Book> books)
        {
            Dictionary<string, double> totalPrices = new Dictionary<string, double>();
            foreach (var book in books)
            {
                if (totalPrices.ContainsKey(book.Author))
                {
                    totalPrices[book.Author] += book.Price;
                }
                else
                {
                    totalPrices[book.Author] = book.Price;
                }
            }

            return totalPrices;
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }

        public Book(string Title, string Author, string Publisher, DateTime ReleaseDate, string ISBN, double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.ReleaseDate = ReleaseDate;
            this.ISBN = ISBN;
            this.Price = Price;
        }

        public Book() { }

    }

    public class Library
    {
        public string Name { get; set; }
        public List<Book> ListOfBooks { get; set; }

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.ListOfBooks = books;
        }

        public Library()
        {
            this.ListOfBooks = new List<Book>();
        }
    }
}
