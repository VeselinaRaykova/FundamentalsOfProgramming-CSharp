using System;
using System.Collections.Generic;
using System.Linq;

namespace _21BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input;
            Library library = new Library();
            DateTime date;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToArray();
                string title = input[0];
                string author = input[1];
                string publisher = input[2];
                DateTime releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", null);
                string ISBN = input[4];
                double price = double.Parse(input[5]);

                Book currBook = new Book(title, author, publisher, releaseDate, ISBN, price);
                library.Books.Add(currBook);
            }

            date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
            library.Books = library.Books
                .Where(x => x.ReleaseDate > date)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title)
                .ToList();

            foreach (Book b in library.Books)
            {
                Console.WriteLine($"{b.Title} -> {b.ReleaseDate.Date.ToString("dd.MM.yyyy")}");
            }
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
        public List<Book> Books { get; set; }

        public Library(string name, List<Book> books)
        {
            this.Name = name;
            this.Books = books;
        }

        public Library()
        {
            this.Books = new List<Book>();
        }
    }
}
