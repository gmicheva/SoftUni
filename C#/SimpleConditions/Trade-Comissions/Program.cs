using System;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double commissions = 0.0;

            switch (town)
            {
                case "Sofia":
                    if (sells >= 0 && sells <= 500)
                    {
                        commissions = sells * 0.05;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commissions = sells * 0.07;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commissions = sells * 0.08;
                    }
                    else if(sells> 1000)
                    {
                        commissions = sells * 0.12;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (sells >= 0 && sells <= 500)
                    {
                        commissions = sells * 0.045;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commissions = sells * 0.075;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commissions = sells * 0.10;
                    }
                    else if (sells > 1000)
                    {
                        commissions = sells * 0.13;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Plovdiv":
                    if (sells >= 0 && sells <= 500)
                    {
                        commissions = sells * 0.055;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        commissions = sells * 0.08;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        commissions = sells * 0.12;
                    }
                    else if (sells > 1000)
                    {
                        commissions = sells * 0.145;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("error");
                    }
                    break;

            }
            if (commissions >0)
            {
                Console.WriteLine($"{commissions:f2}");
            }
        }
    }
}
