using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Boolean even = (number % 2 == 0);

            if (number % 2 == 0)
            { Console.WriteLine("even"); }
            else { Console.WriteLine("odd"); }
        }
    }
}
