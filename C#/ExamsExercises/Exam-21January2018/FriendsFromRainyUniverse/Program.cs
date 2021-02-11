using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendsFromRainyUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> allData = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "End")
            {
                List<string> data = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string name = data[0];
                List<string> dataSplit = data[1].Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string liquidName = dataSplit[0];
                int jarCount = int.Parse(dataSplit[1]);

                if (!allData.ContainsKey(name))
                {
                    allData[name] = new Dictionary<string, int>();
                }

                if (!allData[name].ContainsKey(liquidName))
                {
                    allData[name].Add(liquidName, jarCount);
                }
                else
                {
                    allData[name][liquidName] += jarCount;
                }

                input = Console.ReadLine();
            }

            foreach (var name in allData)
            {
                Console.WriteLine($"{name.Key} Liquids:");

                foreach (var liquid in name.Value.OrderBy(x => x.Value))
                {
                    Console.WriteLine($"--- {liquid.Key}: {liquid.Value}");
                }
            }
        }
    }
}
