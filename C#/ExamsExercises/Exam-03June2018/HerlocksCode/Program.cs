using System;
using System.Collections.Generic;
using System.Linq;

namespace Herlock_s_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> factInput = Console.ReadLine().Split(' ').ToList();

            int numberOfComands = 0;
            long sumOperation = 0;
            long currentSum = 0;

            List<string> operationInput = Console.ReadLine().Split(' ').ToList();

            while (operationInput[0] != "END")
            {
                int operationPosition = int.Parse(operationInput[0]);
                string operationModifier = operationInput[1];

                if (operationPosition >= 0 && operationPosition < factInput.Count)
                {
                    string fact = factInput[operationPosition];

                    if (fact[0] >= 65 && fact[0] <= 90)
                    {
                        switch (operationModifier)
                        {
                            case "Basic":
                                currentSum = (fact[0] + fact[1]) * fact[2];
                                break;

                            case "Weird":
                                currentSum = Math.Abs(fact[1] - fact[2]);
                                break;
                        }
                    }
                    else if (fact[0] >= 48 && fact[0] <= 57)
                    {
                        int factDigit = int.Parse(fact);
                        int thirthDigit = factDigit % 10;
                        int secondDigit = (factDigit / 10) % 10;
                        int firstDigit = factDigit / 100;

                        switch (operationModifier)
                        {
                            case "Basic":
                                currentSum = (firstDigit + secondDigit) * thirthDigit;
                                break;

                            case "Weird":
                                currentSum = Math.Abs(thirthDigit - secondDigit);
                                break;
                        }
                    }
                    else if (fact[0] == 42)
                    {
                        int repeat = fact.Length;

                        if (numberOfComands == 0)
                        {
                            currentSum = 0;
                        }
                        else
                            currentSum = currentSum * repeat;
                    }
                    sumOperation += currentSum;
                    numberOfComands++;
                }
                operationInput = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(sumOperation);
        }
    }
}