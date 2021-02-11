using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MinPalace
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();

            List<Chest> allChests = new List<Chest>();
            int totallitem = 0;
            int importanItem = 0;

            Dictionary<string, List<Item>> allItem = new Dictionary<string, List<Item>>();

            while (data != "END")
            {
                List<string> input = data.Split(new[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (input.Count)
                {
                    case 3:
                        Chest currentChest = new Chest();
                        currentChest.ChestName = input[0];
                        currentChest.Description = input[1];
                        currentChest.Category = input[2];
                        allChests.Add(currentChest);
                        break;

                    case 4:
                        Item currentItem = new Item();
                        currentItem.ItemName = input[0];
                        string chestName = input[1];
                        currentItem.Date = DateTime.ParseExact(input[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        currentItem.ImportanceIndex = int.Parse(input[3]);
                        totallitem++;

                        if (currentItem.ImportanceIndex > 3 && currentItem.Date.Year > 2005)
                        {
                            if (!allItem.ContainsKey(chestName))
                            {
                                allItem[chestName] = new List<Item>();
                            }
                            allItem[chestName].Add(currentItem);
                            importanItem++;
                        }
                        break;
                }

                data = Console.ReadLine();
            }

            Console.WriteLine("Herlock's Mind Palace:");
            Console.WriteLine();

            foreach (Chest chest in allChests)
            {
                Console.WriteLine($"{chest.ChestName} - ({chest.Category})");
                Console.WriteLine($"-- {chest.Description}");

                foreach (var item in allItem.Where(x => x.Key == chest.ChestName))
                {
                    foreach (var name in item.Value)
                    {
                        string month = name.Date.ToString("MMMM", CultureInfo.CurrentUICulture);

                        Console.WriteLine($"---- {name.ItemName}, acquired {month} {name.Date.Year}.");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Herlock's total items: {totallitem}");
            Console.WriteLine($"Herlock's important items: {importanItem}");
        }
    }
    class Chest
    {
        public string ChestName;
        public string Description;
        public string Category;
    }
    class Item
    {
        public string ItemName;
        public DateTime Date;
        public int ImportanceIndex;
    }
}
