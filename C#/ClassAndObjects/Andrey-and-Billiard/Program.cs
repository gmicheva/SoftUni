using System;
using System.Collections.Generic;
using System.Linq;

namespace Andrey_and_Billiard
{
    class Shop
    {
        public string Name;
        public double Price;
    }
    class Client
    {
        public string Name;
        public string Article;
        public double Quantity;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Shop> Entities = new List<Shop>();
            Dictionary<string, double> shopEntitiy = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                List<string> dataEntity = Console.ReadLine().Split('-').ToList();
                Shop currentEntity = new Shop();

                currentEntity.Name = dataEntity[0];
                currentEntity.Price = double.Parse(dataEntity[1]);
                Entities.Add(currentEntity);
            }
            foreach (Shop entity in Entities)
            {
                shopEntitiy[entity.Name] = entity.Price;
            }

            List<string> inputOrders = Console.ReadLine().Split(',', '-').ToList();
            List<Client> Clients = new List<Client>();
            
            while (inputOrders[0]!= "end of clients")
            {
                Client currentClient = new Client();

                currentClient.Name = inputOrders[0];
                currentClient.Article = inputOrders[1];
                currentClient.Quantity = double.Parse(inputOrders[2]);

                if (shopEntitiy.ContainsKey(currentClient.Article))
                {
                    Clients.Add(currentClient);
                }
                

                inputOrders = Console.ReadLine().Split(',', '-').ToList();
            }

            Dictionary<string, Dictionary<string, double>> clientsList = new Dictionary<string, Dictionary<string, double>>();

            foreach (var client in Clients)
            {
                if (!clientsList.ContainsKey(client.Name))
                {
                    clientsList[client.Name] = new Dictionary<string, double>();
                }
                if (!clientsList[client.Name].ContainsKey(client.Article))
                {
                    clientsList[client.Name][client.Article] = client.Quantity;
                }
                else
                {
                    clientsList[client.Name][client.Article] += client.Quantity;
                }
            }

            double bill = 0;
            double totalBill = 0;

            foreach (var client in clientsList.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{client.Key}");
                foreach (var order in client.Value)
                {
                    
                    Console.WriteLine($"-- {order.Key} - {order.Value}");

                    bill += order.Value * shopEntitiy[order.Key];
                     
                 }
                Console.WriteLine($"Bill: {bill:0.00}");
                totalBill += bill;
                bill = 0;
                
            }
            Console.WriteLine($"Total bill: {totalBill:0.00}");
        }
    }
}
