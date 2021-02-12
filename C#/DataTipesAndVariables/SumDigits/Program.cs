using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int digitSum = 0;

            do
            {
                digitSum += num % 10;
                num /= 10;
            } 
            while (num > 0);                
              
            Console.WriteLine(digitSum);
        }
    }
}
