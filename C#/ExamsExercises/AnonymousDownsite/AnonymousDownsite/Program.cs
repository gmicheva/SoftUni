using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _1._Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            double siteLost = 0;
            int countAffectSite = 0;
            List<string> affectSite = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split(' ').ToList();
                string name = data[0];
                int visits = int.Parse(data[1]);
                double commercial = double.Parse(data[2]);
                siteLost += visits * commercial;
                countAffectSite++;

                affectSite.Add(name);
            }

            foreach (string site in affectSite)
            {
                Console.WriteLine(site);
            }
            BigInteger securityToken = (BigInteger)Math.Pow(securityKey, countAffectSite);
            Console.WriteLine($"Total Loss: {siteLost:0.00000000000000000000}");
            Console.WriteLine($"Security Token: {securityKey}");
        }
    }
}
