using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputRes = Console.ReadLine();

            Dictionary<string, long> recources = new Dictionary<string, long>();

            while (inputRes != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());

                if (recources.ContainsKey(inputRes))
                {
                    recources[inputRes] += quantity;
                }
                else
                {
                    recources[inputRes] = quantity;
                }

                inputRes = Console.ReadLine();
            }

            foreach (KeyValuePair<string, long> item in recources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
