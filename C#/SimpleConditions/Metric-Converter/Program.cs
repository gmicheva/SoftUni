using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string metricIn = Console.ReadLine();
            string metricOut = Console.ReadLine();

             double mm = 1000;
             double cm = 100;
             double mi = 0.000621371192;
             double inches = 39.3700787;
             double km = 0.001;
             double ft = 3.2808399;
             double yd = 1.0936133;



            //Convert into meters
            if (metricIn == "cm")
            {
                number = number / cm;
            }
            else if (metricIn == "mm")
            {
                number = number / mm;
            }
            else if (metricIn == "mi")
            {
                number = number / mi;
            }
            else if (metricIn == "in")
            {
                number = number / inches;
            }
            else if (metricIn == "km")
            {
                number = number / km;
            }
            else if (metricIn == "ft")
            {
                number = number / ft;
            }
            else if (metricIn == "yd")
            {
                number = number / yd;
            }

            //Convert from meters to output meters

            if (metricOut == "cm")
            {
                number = number * cm;
            }
            else if (metricOut == "mi")
            {
                number = number * mi;
            }
            else if (metricOut == "in")
            {
                number = number * inches;
            }
            else if (metricOut == "km")
            {
                number = number * km;
            }
            else if (metricOut == "ft")
            {
                number = number * ft;
            }
            else if (metricOut == "yd")
            {
                number = number * yd;
            }
            else if (metricOut == "mm")
            {
                number = number * mm;
            }

            double result = Math.Round(number, 8);

            Console.WriteLine(result);
        }
    }
}
