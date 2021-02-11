using System;

namespace Time__15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursToMinutes = hours * 60;
            int allTime = hoursToMinutes + minutes;
            int newTime = allTime + 15;
            hours = newTime / 60;
            minutes = newTime % 60;
            string newTime24 = "";

            
            if (hours < 24)
            {
                if (minutes < 10)
                    Console.WriteLine($"{hours}:0{minutes}");

                else
                {
                    Console.WriteLine($"{hours}:{minutes}");
                }
            }
            else if (hours == 24)
            {
                
                if (minutes < 10)
                    Console.WriteLine($"0:0{minutes}");

                else
                {
                    Console.WriteLine($"0:{minutes}");
                }
            }
        }
    }
}
