using System;
using System.Collections.Generic;
using System.Linq;

namespace LoginReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string inputPassword = Console.ReadLine();

            string password = string.Concat(username.Reverse());
            int counter = 0;
            while (counter < 4)
            {
                if (inputPassword.Equals(password))
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }

                }
                inputPassword = Console.ReadLine();
            }
        }
    }
}
