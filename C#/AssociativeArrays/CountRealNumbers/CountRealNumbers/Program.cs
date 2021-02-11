using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            Dictionary<double, int> occurence = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                double curentNumber = numbers[i];
                List<double> repeatNum = numbers.Where(x => x == curentNumber).ToList();
                int occurenceCount = repeatNum.Count;
                occurence[curentNumber] = occurenceCount;
            }

            foreach (KeyValuePair<double, int> item in occurence.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
