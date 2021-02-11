using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            double income = 0.0;

            switch (projection)
            {
                case "Premiere":
                    income = 12 * row * column;
                    break;

                case "Normal":
                    income = 7.5 * row * column;
                    break;

                case "Discount":
                    income = 5 * row * column;
                    break;
            }
            Console.WriteLine($"{income:f2}");
        }
    }
}
