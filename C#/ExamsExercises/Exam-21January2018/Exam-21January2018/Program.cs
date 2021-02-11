using System;
using System.Collections.Generic;
using System.Linq;

namespace UndergroundWaters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> airArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> raindropsArr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            airArr.Insert(0, 0);
            airArr.Add(0);

            int counter = 0;
            int localMaximumValueAir = 0;

            for (int i = 1; i < airArr.Count - 1; i++)
            {
                int localValue;

                if (airArr[i] > airArr[i - 1] && airArr[i] > airArr[i + 1])
                {
                    localValue = airArr[i];
                    counter++;

                    if (localValue > localMaximumValueAir)
                    {
                        localMaximumValueAir = localValue;
                    }
                }
            }

            for (int i = 0; i < raindropsArr.Count; i++)
            {
                raindropsArr[i] = raindropsArr[i] - counter;
            }

            raindropsArr.RemoveAll(x => x <= 0);
            int localMaximumValueRain = 0;

            if (raindropsArr.Count == 1)
            {
                localMaximumValueRain = raindropsArr[0];
            }
            else
            {
                raindropsArr.Insert(0, 0);
                raindropsArr.Add(0);

                for (int i = 1; i < raindropsArr.Count - 1; i++)
                {
                    int localValue;
                    if (raindropsArr[i] > raindropsArr[i - 1] && raindropsArr[i] > raindropsArr[i + 1])
                    {
                        localValue = raindropsArr[i];
                        if (localValue > localMaximumValueRain)
                        {
                            localMaximumValueRain = localValue;
                        }
                    }
                }
            }

            if (localMaximumValueAir == localMaximumValueRain)
            {
                Console.WriteLine("Something interesting was found!");
                Console.WriteLine($"Sum: {localMaximumValueAir + localMaximumValueRain}");
            }
            else
            {
                Console.WriteLine("There is nothing unordinary!");
                Console.WriteLine($"Difference: {Math.Abs(localMaximumValueAir - localMaximumValueRain)}");
            }
        }
    }
}