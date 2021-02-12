using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); //poke power
            int m = int.Parse(Console.ReadLine()); //distance between the poke targets
            int y = int.Parse(Console.ReadLine()); //exhaustionFactor
            int n = pokePower;
            int countPoked = 0;

            while (n > m)
            {
                n -= m;
                countPoked++;

                double percent = (double)pokePower * 0.5;
                if (n == percent && y != 0)
                {
                    n = n / y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(countPoked);
        }
    }
}
