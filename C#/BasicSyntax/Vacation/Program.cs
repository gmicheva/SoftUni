using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int nStart = int.Parse(Console.ReadLine());
            int nEnd = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = nStart; i <= nEnd; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
