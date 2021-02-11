using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int countTrashesHeadset = lostGames / 2;
            int countTrashesMouse = lostGames / 3;
            int countTrashesKeyboard = lostGames / 6;
            int countTrashesDisplay = countTrashesKeyboard / 2;

            double allExpenses = countTrashesHeadset * headsetPrice +
                                 countTrashesMouse * mousePrice +
                                 countTrashesKeyboard * keyboardPrice +
                                 countTrashesDisplay * displayPrice;

            Console.WriteLine($"Rage expenses: {allExpenses:F2} lv.");
        }
    }
}
