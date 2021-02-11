using System;

namespace MakeItRain
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = int.Parse(Console.ReadLine());
            double t = 0;
            double f = 0;

            for (int i = 0; i < loop; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                if (IsDivide(a, b, c))
                {
                    t += 84;
                    f = Math.Round(f / 8.4);
                }
                else
                {
                    f += 70;
                    t = Math.Round(t / 7);
                }
            }

            Console.WriteLine($"T: {t:0}");
            Console.WriteLine($"F: {f:0}");

            if ((t / f) % 2 == 0)
            {
                Console.WriteLine($"Got a Roin coin: True");
            }
            else
            {
                Console.WriteLine($"Got a Roin coin: False");
            }
        }
        static bool IsDivide(int A, int B, int C)
        {
            bool isDivede = true;

            if (A / B != C)
            {
                isDivede = false;
            }
            return isDivede;
        }
    }
}
