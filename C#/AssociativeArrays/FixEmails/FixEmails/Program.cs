using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dictionary<string, string> emailBook = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                if (!(email.Contains(".us") || email.Contains(".uk")))
                {
                    emailBook[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> item in emailBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
