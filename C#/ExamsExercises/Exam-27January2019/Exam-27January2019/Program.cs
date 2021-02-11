using System;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userNameIsTrue = false;
            string input = Console.ReadLine();
            //char[] unvalidSymbol = { ' ', '!', '(', ')', ',', '.', '\'', '\"', ':', ';', '[', ']', '\\', '/', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            while (!userNameIsTrue)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] >= 65 && input[i] <= 90 || input[i] >= 97 && input[i] <= 122)
                    {
                        userNameIsTrue = true;
                    }
                    else
                    {
                        userNameIsTrue = false;
                        Console.WriteLine("Invalid username!");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
