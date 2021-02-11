using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quntity = double.Parse(Console.ReadLine());
            double price = 0.0;

            
            if (dayOfWeek=="Saturday" || dayOfWeek=="Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        break;

                    case "apple":
                        price = 1.25;
                        break;

                    case "orange":
                        price = 0.90;
                        break;

                    case "grapefruit":
                        price = 1.60;
                        break;

                    case "kiwi":
                        price = 3;
                        break;

                    case "pineapple":
                        price = 5.6;
                        break;

                    case "grapes":
                        price = 4.2;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;

                }
                
            }
            else if (dayOfWeek=="Monday" || dayOfWeek=="Tuesday" || dayOfWeek=="Wednesday" 
                || dayOfWeek=="Thursday" || dayOfWeek=="Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        break;

                    case "apple":
                        price = 1.20;
                        break;

                    case "orange":
                        price = 0.85;
                        break;

                    case "grapefruit":
                        price = 1.45;
                        break;

                    case "kiwi":
                        price = 2.7;
                        break;

                    case "pineapple":
                        price = 5.5;
                        break;

                    case "grapes":
                        price = 3.85;
                        break;

                    default:
                        Console.WriteLine("error");
                        break;

                }
                
            }
            else
            {
                Console.WriteLine("error");
            }
            if (price >0)
            {
                double result = price * quntity;
                Console.WriteLine($"{result:f2}");
            }
        }
    }
}
