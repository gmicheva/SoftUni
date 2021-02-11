using System;

namespace World_ofCodecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = 0;
            int counterMinTemp = 0;
            bool isWarriosGo = true;
            double minTemp = Double.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                temperature = double.Parse(Console.ReadLine());

                if (temperature < 0)
                {
                    counterMinTemp++;

                }

                if (counterMinTemp >= 5 || temperature < -10 || temperature > 45)
                {
                    isWarriosGo = false;
                }

                if (temperature < minTemp)
                {
                    minTemp = temperature;
                }
            }

            if (isWarriosGo)
            {
                Console.WriteLine($"The lowest temperature is { minTemp:0.0} degrees. The coders are off to battle!");
            }
            else
            {
                Console.WriteLine($"The lowest temperature is {minTemp:0.0} degrees. The coders rest.");
            }
        }
    }
}
