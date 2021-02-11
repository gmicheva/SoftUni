using System;

namespace Sum_Digits_of_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < numAsString.Length; i++)
            {
                sum += int.Parse(numAsString[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
