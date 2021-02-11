using System;
using System.Collections.Generic;
using System.Linq;

namespace DataBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> input = new List<double>();
            List<double> avValue = new List<double>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                double sum = (double)Math.Ceiling(input.Average());
                avValue.Add((int)Math.Round(sum));
            }

            int d = int.Parse(Console.ReadLine());

            List<double> listAfterDivisiable = new List<double>();

            foreach (double item in avValue.Where(x => x % d != 0 || x == 0))
            {
                listAfterDivisiable.Add(item);
            }

            double minValue = double.MaxValue;

            foreach (double item in listAfterDivisiable)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }

            if (minValue == 0)
            {
                Console.WriteLine($"The inputs seem to be perfectly balanced, as all things should be. Count of all arrays: { n}.");
            }
            else if (minValue < 0)
            {
                Console.WriteLine($"The inputs seem to be negatively weighted. Negative weight: {minValue:0}");
            }
            else
            {
                Console.WriteLine($"The inputs seem to be positively weighted. Positive weight: {minValue:0}");
            }
        }
    }
}
