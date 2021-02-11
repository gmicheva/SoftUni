using System;
using System.Collections.Generic;
using System.Linq;

namespace LootMadness
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong gold = ulong.Parse(Console.ReadLine());
            double health = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Dictionary<string, List<Item>> allItems = new Dictionary<string, List<Item>>();
            List<Item> items = new List<Item>();

            while (input != "NO MORE LOOT")
            {
                List<string> data = input.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (data[0])
                {
                    case "Gold":

                        ulong currentGold = ulong.Parse(data[1]);
                        gold += currentGold;
                        break;

                    default:

                        string name = data[0];
                        List<string> item = data[1].Split(' ').ToList();
                        string quality = item[0];
                        currentGold = ulong.Parse(item[1]);
                        double currentHealth = double.Parse(item[2]);

                        if (quality == "Rare" || quality == "Legendary")
                        {

                            if (!allItems.ContainsKey(name))
                            {
                                Item currentItem = new Item();
                                currentItem.Name = name;
                                currentItem.Quality = quality;
                                currentItem.HealthBonus = currentHealth;

                                items.Add(currentItem);
                                allItems[name] = new List<Item>();
                                allItems[name] = items;

                                health += currentHealth;

                            }
                            else if (quality == "Rare" && allItems.ContainsKey(name))
                            {
                                gold += currentGold;
                            }

                        }
                        else
                        {
                            gold += currentGold;
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Marto has a total of {gold} gold.");
            Console.WriteLine($"Marto's total health is {health}.");
            Console.WriteLine("Marto has collected the following items:");

            foreach (Item item in items)
            {
                Console.WriteLine($"> {item.Name} [Quality: {item.Quality}] [HP Bonus: {item.HealthBonus}]");
            }
        }
    }
    class Item
    {
        public string Name;
        public string Quality;
        public double HealthBonus;
    }
}
