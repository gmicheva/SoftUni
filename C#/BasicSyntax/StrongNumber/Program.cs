using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string numToString = num.ToString();
            int sumFactoriel = 0;
            

            for (int i = 0; i < numToString.Length; i++)
            {
                int curentNum = int.Parse(numToString[i].ToString());
                int sum = 1;
                for (int j = 1; j <= curentNum; j++)
                {
                    sum *= j;
                }
                sumFactoriel += sum;                
            }
            if (sumFactoriel == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
