using System;
using System.Collections.Generic;
using System.Linq;

namespace Hero_of_Eldevir
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string inputCommand = Console.ReadLine();
            List<string> listCommand = new List<string>();

            while (inputCommand != "Battle" && data.Count > 0)
            {
                listCommand = inputCommand.Split(new[] { ' ', '/' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string command = listCommand[0];
                string item = listCommand[1];

                switch (command)
                {
                    case "Loot":
                        if (!data.Contains(item))
                        {
                            data.Add(item);
                            Console.WriteLine($"{item} has been added to the inventory.");
                        }
                        break;

                    case "Disenchant":
                        if (data.Contains(item))
                        {
                            data.Remove(item);

                            if (data.Count > 0)
                            {
                                Console.WriteLine($"{ item} has been disenchanted.");
                            }
                            else
                            {
                                Console.WriteLine("The inventory is empty.");
                                return;
                            }
                        }
                        break;

                    case "Upgrade":
                        if (data.Contains(item))
                        {
                            string wordForUpgrade = listCommand[2];
                            string upgradeItem = item + " ~ " + wordForUpgrade;
                            data[data.FindIndex(x => x.Equals(item))] = upgradeItem;

                            Console.WriteLine($"{item} has been upgraded to {item} ~ { wordForUpgrade}.");
                        }
                        break;
                }

                inputCommand = Console.ReadLine();
            }

            if (data.Count > 0)
            {
                Console.WriteLine("Red Paladin's inventory :");

                foreach (string item in data)
                {
                    Console.WriteLine($"--> {item}");
                }
            }
        }
    }
}
