using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Library
{
    class BooksLibary
    {
        public string Title;
        public string Author;
        public string Publisher;
        public string ReleaseDate;
        public int ISBNnumber;
        public double Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BooksLibary> books = new List<BooksLibary>();
            
            Dictionary<string, double> TotalSumBooks = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split(' ').ToList();
                BooksLibary currentBook = new BooksLibary();

                currentBook.Title = data[0];
                currentBook.Author = data[1];
                currentBook.Publisher = data[2];
                currentBook.ReleaseDate = data[3];
                currentBook.ISBNnumber = int.Parse(data[4]);
                currentBook.Price = double.Parse(data[5]);

                books.Add(currentBook);
            }
            foreach (BooksLibary book in books)
            {
                if (!TotalSumBooks.ContainsKey(book.Author))
                {
                    TotalSumBooks[book.Author] = 0;
                }
                TotalSumBooks[book.Author] += book.Price;
            }
            foreach (KeyValuePair<string, double> book in TotalSumBooks.OrderByDescending(x => x.Value).ThenBy(x =>x.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Value:0.00}");
            }
        }
    }
}
