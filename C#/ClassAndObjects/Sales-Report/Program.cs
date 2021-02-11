using System;
using System.Collections.Generic;
using System.Linq;


namespace Sales_Report
{
    class Sale
    {
        public string Town;
        public string Product;
        public double Quantity;
        public double Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();
            Dictionary<string, double> townSales = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split(' ').ToList();

                Sale currentSale = new Sale();
                currentSale.Town = data[0];
                currentSale.Product = data[1];
                currentSale.Price = double.Parse(data[2]);
                currentSale.Quantity = double.Parse(data[3]);

                sales.Add(currentSale);
            }
            foreach (Sale sale in sales)
            {
                if (!townSales.ContainsKey(sale.Town))
                {
                    townSales[sale.Town] = 0;
                }

                townSales[sale.Town] += sale.Price * sale.Quantity;

            }
            foreach (KeyValuePair<string, double> sale in townSales)
            {
                Console.WriteLine($"{sale.Key} -> {townSales.Values:0.00}");
            }
        }
    }
}
