using System;

namespace IntegerTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number1 = byte.Parse(Console.ReadLine());
            uint number2 = uint.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            long number4 = long.Parse(Console.ReadLine());

            Console.Write($"{number1} {number2} {number3} {number4}");
        }
    }
}
