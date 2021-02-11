using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string destinationStar = Console.ReadLine();
            double distance = long.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double fuelConsumation = double.Parse(Console.ReadLine());
            double gasPrice = double.Parse(Console.ReadLine());

            double litersPerGm = fuelConsumation / 100;
            double pricePerGm = litersPerGm * gasPrice;
            double needPrice = distance * pricePerGm;

            if (budget >= needPrice)
            {
                Console.WriteLine($"Off to {destinationStar} with ${(budget-needPrice):0.00} for snacks");
            }
            else
            {
                Console.WriteLine($"Maybe another time, need ${(needPrice - budget):0.00} more");
            }
        }
    }
}
