using System;

namespace Equal_Pairs_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxDiff = 0;
            int sum = 0;
            int sum2 = 0;
            int dif = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum = num1 + num2;
                if (i != 0)
                {
                    dif = Math.Abs(sum - sum2);
                    if (dif > maxDiff)
                    {
                        maxDiff = dif;
                    }
                }
                    sum2 = sum;
                
            }
            if (dif == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
