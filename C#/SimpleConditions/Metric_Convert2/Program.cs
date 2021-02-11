using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var inputFormat = Console.ReadLine();
            var outputFormat = Console.ReadLine();

            const double mm = 1000;
            const double cm = 100;
            const double mi = 0.000621371192;
            const double inches = 39.3700787;
            const double km = 0.001;
            const double ft = 3.2808399;
            const double yd = 1.0936133;

            // Convert into meters
            if (inputFormat == "mm")
            {
                distance /= mm;
            }
            else if (inputFormat == "cm")
            {
                distance /= cm;
            }
            else if (inputFormat == "mi")
            {
                distance /= mi;
            }
            else if (inputFormat == "in")
            {
                distance /= inches;
            }
            else if (inputFormat == "km")
            {
                distance /= km;
            }
            else if (inputFormat == "ft")
            {
                distance /= ft;
            }
            else if (inputFormat == "yd")
            {
                distance /= yd;
            }

            // Convert from meters
            if (outputFormat == "mm")
            {
                distance *= mm;
            }
            else if (outputFormat == "cm")
            {
                distance *= cm;
            }
            else if (outputFormat == "mi")
            {
                distance *= mi;
            }
            else if (outputFormat == "in")
            {
                distance *= inches;
            }
            else if (outputFormat == "km")
            {
                distance *= km;
            }
            else if (outputFormat == "ft")
            {
                distance *= ft;
            }
            else if (outputFormat == "yd")
            {
                distance *= yd;
            }

            var result = Math.Round(distance, 8);
            Console.WriteLine(result);
        }
    }
}