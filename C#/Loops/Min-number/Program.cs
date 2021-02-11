﻿using System;

namespace Min_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number <= minNumber)
                {
                    minNumber = number;
                }
             }
            Console.WriteLine(minNumber);
        }
    }
}
