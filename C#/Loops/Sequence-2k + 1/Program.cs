using System;

namespace Sequence_2k___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i= i*2+1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
