using System;

namespace Check_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            if (number == 2)
            {
                Console.WriteLine("Prime");
            }
            else if (number < 2)
            {
                Console.WriteLine("Not prime");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                      
                    }
                    
                }
                if (counter >0)
                {
                    Console.WriteLine("Not prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
        }
    }
}
