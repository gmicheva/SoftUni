using System;

namespace Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int counterCol = 0;
            int counterRow = 0;
       

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    number = row + col + 1;
                    if (number>n)
                    {
                        number = 2 * n - number;
                    }

                    Console.Write(number + " ");
                    counterCol++;

                    if (counterCol == n)
                    {
                        Console.WriteLine();
                        counterCol = 0;
                        break;

                    }
                }
                counterRow++;
                if (counterRow == n)
                {
                    break;
                }
            }
        }
    }
}
