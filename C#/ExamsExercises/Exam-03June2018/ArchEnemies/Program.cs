using System;
using System.Collections.Generic;
using System.Linq;

namespace Arch_Enemies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();
            Dictionary<string, List<int>> casesSolve = new Dictionary<string, List<int>>();
            Dictionary<string, int> bestTimeH = new Dictionary<string, int>();
            Dictionary<string, int> bestTimeM = new Dictionary<string, int>();

            long allTimeHerlock = 0;
            long allTimeMames = 0;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string caseForSolve = input[0];
                List<int> times = input[1].Split().Select(int.Parse).ToList();

                if (times[0] > 0 && times[1] > 0 && times[0] != times[1])
                {
                    if (!casesSolve.ContainsKey(caseForSolve))
                    {
                        casesSolve[caseForSolve] = new List<int>();
                    }
                    casesSolve[caseForSolve] = times;
                }

            }

            foreach (KeyValuePair<string, List<int>> item in casesSolve)
            {
                allTimeHerlock += item.Value[0];
                allTimeMames += item.Value[1];

                if (item.Value[0] < item.Value[1])
                {
                    bestTimeH[item.Key] = item.Value[0];
                }
                else
                {
                    bestTimeM[item.Key] = item.Value[1];
                }
            }
            Console.WriteLine("Herlock's Cases:");

            foreach (var time in bestTimeH.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-- {time.Key}: {time.Value}s.");
            }

            Console.WriteLine();
            Console.WriteLine("Mames's Cases:");

            foreach (var time in bestTimeM.OrderBy(x => x.Key))
            {
                Console.WriteLine($"-- {time.Key}: {time.Value}s.");
            }
            Console.WriteLine();

            if (allTimeHerlock < allTimeMames)
            {
                Console.WriteLine($"The winner is: Herlock");
            }
            else if (allTimeHerlock > allTimeMames)
            {
                Console.WriteLine($"The winner is: Mames");
            }
            else
            {
                Console.WriteLine("No winner.");
            }
        }
    }
}
