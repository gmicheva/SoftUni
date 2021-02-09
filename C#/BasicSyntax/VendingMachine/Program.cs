using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (!input.Equals("Start"))
            {
                double money = double.Parse(input);
                List<double> workingCoins = new List<double>() { 0.1, 0.2, 0.5, 1.0, 2 };

                if (workingCoins.Contains(money))
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                input = Console.ReadLine();
            }

            string order = Console.ReadLine();
            double price = 0;
            bool flag = true;

            while (!(order.Equals("End")))
            {
                flag = false;
                switch (order.ToLower())
                {
                    case "nuts":
                        price = 2;
                        flag = true;
                        break;
                    case "water":
                        price = 0.7;
                        flag = true;
                        break;
                    case "crisps":
                        price = 1.5;
                        flag = true;
                        break;
                    case "soda":
                        price = 0.8;
                        flag = true;
                        break;
                    case "coke":
                        price = 1;
                        flag = true;
                        break;
                }
                if (flag == false)
                {
                    Console.WriteLine("Invalid product.");
                }
                else if (sum < price)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine($"Purchased {order.ToLower()}");
                    sum -= price;
                }
                
                price = 0;
                order = Console.ReadLine();
            }
            Console.WriteLine($"Change:{(sum - price):F2}");
        }
    }
}

