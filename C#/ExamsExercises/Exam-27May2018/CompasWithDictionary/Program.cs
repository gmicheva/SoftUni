using System;
using System.Collections.Generic;

namespace CompasWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            char initialDirection = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            Dictionary<char, string> direction = new Dictionary<char, string>
            {
                { 'N', "North" },
                { 'E', "East" },
                { 'S', "South" },
                { 'W', "West" }
            };

            Dictionary<char, int> startPosition = new Dictionary<char, int>
            {
                { 'N', 0 },
                { 'E', 1 },
                { 'S', 2 },
                { 'W', 3 }
            };

            Dictionary<int, string> legend = new Dictionary<int, string>
            {
                { 0, "North" },
                { 1, "East" },
                { 2, "South" },
                { 3, "West" }
            };

            int allDegrees = 0;

            while (input != "END")
            {
                int degrees = int.Parse(input);
                allDegrees += degrees;
                input = Console.ReadLine();
            }

            int steps = Math.Abs(allDegrees / 45);

            if (steps > 3)
            {
                steps = steps % 4;
            }

            int finalDirection = 0;

            if (allDegrees > 0)
            {
                finalDirection = startPosition[initialDirection] + steps;
            }
            else
            {
                finalDirection = Math.Abs(startPosition[initialDirection] - steps);
            }

            if (finalDirection > 3)
            {
                finalDirection = finalDirection % 4;
            }

            if (startPosition[initialDirection] - steps < 0)
            {
                finalDirection = 4 - finalDirection;
            }

            Console.WriteLine($"Starting Position: {direction[initialDirection]}");
            Console.WriteLine($"Position After Rotating: {legend[finalDirection]}");
        }
    }
}
