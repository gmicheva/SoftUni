using System;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string kind = "";

            if (item.Equals("banana") ||
                item.Equals("apple") ||
                item.Equals("kiwi") ||
                item.Equals("cherry") ||
                item.Equals("lemon") ||
                item.Equals("grapes"))
            {
                kind = "fruit";
            }
            else if (item == "tomato" || item == "cucumber" || item == "pepper" || item == "carrot")
            { kind = "vegetable";
            }
            else
            {
                kind = "unknown";
            }
            Console.WriteLine(kind);
        }
    }
}
