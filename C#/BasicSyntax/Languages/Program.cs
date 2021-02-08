using System;

namespace Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = null;

            switch (country)
            {
                case "England":
                case "Usa":
                    language = "English";
                    break;
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "Unknown";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}
