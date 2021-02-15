using System;

namespace ShiftArreyLeftByGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new[] { 1, 2, 3, 4, 5, 6, 7 };
            int numOfRotated = int.Parse(Console.ReadLine()); //number of rotated

            for (int i = 0; i < numOfRotated; i++)
            {
                int firstEl = input[0];

                for (int j = 0; j < input.Length-1; j++)
                {
                    input[j] = input[j + 1];                    
                }
                input[input.Length - 1] = firstEl;
            }
            foreach (var item in input)
            {
                Console.Write(item);
            }
        }
    }
}
