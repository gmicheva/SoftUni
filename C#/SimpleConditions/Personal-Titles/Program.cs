using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            string titles = "";

            switch (sex)
            {
                case "f":
                    
                        if (age < 16)
                        {
                        titles = "Miss";
                        }
                    else
                    {
                        titles = "Ms.";
                    }
                    break;
                case "m":
                    if (age < 16)
                    {
                        titles = "Master";
                    }
                    else
                    {
                        titles = "Mr.";
                    }
                    break;
            }
            Console.WriteLine(titles);
        }
    }
}
