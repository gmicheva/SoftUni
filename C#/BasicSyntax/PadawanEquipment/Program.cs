using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            int freeBelts = students / 6;

            double allPrice = Math.Ceiling(students * 1.1) * priceLightsabers  + 
                              students * priceRobes + 
                              (students-freeBelts)*priceBelts;

            if (money >= allPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {allPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(allPrice - money):F2}lv more.");
            }
        }
    }
}
