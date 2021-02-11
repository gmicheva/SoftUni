using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Book_Library_Modification
{
    class BooksLibary
    {
        public string Title;
        public string Author;
        public string Publisher;
        public DateTime ReleaseDate;
        public string ISBNnumber;
        public double Price;
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BooksLibary> books = new List<BooksLibary>();

            
            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split(' ').ToList();
                BooksLibary currentBook = new BooksLibary();
                {
                    currentBook.Title = data[0];
                    currentBook.Author = data[1];
                    currentBook.Publisher = data[2];
                    currentBook.ReleaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    currentBook.ISBNnumber = data[4];
                    currentBook.Price = double.Parse(data[5]);
                };
                books.Add(currentBook);
            }
            DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (BooksLibary book in books.Where(x => x.ReleaseDate>inputDate).
                OrderBy(x => x.ReleaseDate).ThenBy(x => x.Title))
            {

                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }
}
