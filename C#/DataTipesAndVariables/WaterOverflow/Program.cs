using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int sumQuantities = 0;

            for (int i = 0; i < n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                sumQuantities += quantities;

                if ((capacity - sumQuantities) < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sumQuantities -= quantities;
                }
            }

            Console.WriteLine(sumQuantities);            
        }
    }
}
