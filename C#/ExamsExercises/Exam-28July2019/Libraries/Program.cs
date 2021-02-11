using System;
using System.Collections.Generic;
using System.Linq;

namespace Libraries
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> allLibery = new Dictionary<string, string>();
            Dictionary<string, List<string>> allBooks = new Dictionary<string, List<string>>();

            while (input != "Done")
            {
                List<string> data = input.Split(':').ToList();
                string command = data[0];
                switch (command)
                {
                    case "Library":
                        string libaryname = data[1];
                        string town = data[2];

                        if (!allLibery.ContainsKey(libaryname))
                        {
                            allLibery[libaryname] = town;
                        }
                        break;

                    case "Book":
                        string bookName = data[1];
                        string liberyName = data[2];

                        if (allLibery.ContainsKey(liberyName))
                        {
                            if (!allBooks.ContainsKey(liberyName))
                            {
                                allBooks[liberyName] = new List<string>();
                            }

                            allBooks[liberyName].Add(bookName);
                        }
                        else
                        {
                            Console.WriteLine($"Library {liberyName} does not exist!");
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (var libery in allLibery)
            {
                Console.WriteLine($"Library {libery.Key}, based in {libery.Value}:");

                foreach (var book in allBooks.Where(x => x.Key == libery.Key))
                {
                    Console.WriteLine($"{string.Join(", ", book.Value)}");
                }
            }
        }
    }
}
