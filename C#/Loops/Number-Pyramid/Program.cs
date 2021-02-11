using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            
            for (int row = 1; row <= number; row++)
            {
                for (int numberPerRow = 1; numberPerRow <= row; numberPerRow++)
                {

                    Console.Write(counter + " ");
                    counter++;
                    if (counter > number)
                    {
                        break;
                    }

                }
                Console.WriteLine();
                if (counter > number)
                {
                    break;
                }
            }
        }
    }
}
