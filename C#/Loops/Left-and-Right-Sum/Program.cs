using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                int leftNum = int.Parse(Console.ReadLine());
                sumLeft += leftNum;
            }
            for (int j = 0; j < n; j++)
            {
                int rightNum = int.Parse(Console.ReadLine());
                sumRight += rightNum;
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }
            else
            {
                int diff = Math.Abs(sumLeft - sumRight);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
