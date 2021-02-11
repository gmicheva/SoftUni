using System;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double flotingPointNumber = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double metersTraveled = (wingFlaps / 1000) * flotingPointNumber;
            double secundsPassed = wingFlaps / 100;
            double secondsAll = (wingFlaps / endurance) * 5 + secundsPassed;

            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondsAll} s.");
        }
    }
}
