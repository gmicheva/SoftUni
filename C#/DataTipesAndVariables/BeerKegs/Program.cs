using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKeg = int.Parse(Console.ReadLine());
            double biggestVolum = 0;
            string biggestKeg = null;
            

            for (int i = 0; i < numOfKeg; i++)
            {
                string typeOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double currentVolum = Math.PI * Math.Pow(radius, 2) * height;

                if (currentVolum > biggestVolum)
                {
                    biggestVolum = currentVolum;
                    biggestKeg = typeOfKeg;                    
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
