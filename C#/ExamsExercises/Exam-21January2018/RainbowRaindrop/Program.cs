using System;
using System.Collections.Generic;
using System.Linq;

namespace RainbowRaindrop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Rainbow> rainbowDrops = new List<Rainbow>();

            while (input != "End")
            {
                List<string> raindrop = input.Split(' ').ToList();

                if (raindrop.Count == 4)
                {
                    double volume = double.Parse(raindrop[0]);
                    int redColorV = int.Parse(raindrop[1]);
                    int greenColorV = int.Parse(raindrop[2]);
                    int blueColorV = int.Parse(raindrop[3]);

                    if (redColorV < 0 || redColorV > 255)
                    {
                        redColorV = 0;
                    }

                    if (greenColorV < 0 || greenColorV > 255)
                    {
                        greenColorV = 0;
                    }

                    if (blueColorV < 0 || blueColorV > 255)
                    {
                        blueColorV = 0;
                    }

                    if ((redColorV > 200 && greenColorV < 100 && blueColorV < 100) ||
                        (redColorV < 100 && greenColorV > 200 && blueColorV < 100) ||
                        (redColorV < 100 && greenColorV < 100 && blueColorV > 200))
                    {
                        Rainbow drop = new Rainbow();
                        drop.Volume = volume;
                        drop.RedColor = redColorV;
                        drop.GreenColor = greenColorV;
                        drop.BlueColor = blueColorV;
                        rainbowDrops.Add(drop);
                    }
                }

                input = Console.ReadLine();
            }

            int count = 0;
            Console.WriteLine($"Rainbow Raindrops: {rainbowDrops.Count}");

            foreach (Rainbow drop in rainbowDrops.OrderBy(x => x.Volume))
            {
                count++;
                Console.WriteLine($"{count}. V:{drop.Volume:0.00} -> R:{drop.RedColor} G:{drop.GreenColor} B:{drop.BlueColor}");
            }
        }
        class Rainbow
        {
            public double Volume;
            public int RedColor;
            public int GreenColor;
            public int BlueColor;
        }
    }
}
