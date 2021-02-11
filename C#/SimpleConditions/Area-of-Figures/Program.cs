using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double sideA = double.Parse(Console.ReadLine());
            double sideB = 0.0;
            double area = 0.0;

            if (figure.Equals("square"))
            {
                area = sideA * sideA;
            }
            else if (figure.Equals("rectangle"))
            {
                sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (figure.Equals("circle"))
            {
                area = Math.PI * sideA * sideA;
            }
            else if (figure.Equals("triangle"))
            {
                sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB / 2;
            }
            Console.WriteLine(Math.Round(area,3));
        }
    }
}
