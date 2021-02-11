using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideB1 = double.Parse(Console.ReadLine());
            double sideB2 = double.Parse(Console.ReadLine());
            double sideH = double.Parse(Console.ReadLine());
            double area = (sideB1 + sideB2) * sideH / 2;
            Console.WriteLine(area);
        }
    }
}
