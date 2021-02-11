using System;
using System.Collections.Generic;
using System.Linq;


namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (data[0] != "END")
            {
                string command = data[0];

                switch (command)
                {
                    case "A":
                        string name = data[1];
                        string number = data[2];
                        phonebook[name] = number;
                        break;

                    case "S":
                        name = data[1];
                        if (phonebook.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {phonebook[name]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                        break;

                    case "ListAll":
                        foreach (KeyValuePair<string, string> item in phonebook.OrderBy(x => x.Key))
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                        break;
                }

                data = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
