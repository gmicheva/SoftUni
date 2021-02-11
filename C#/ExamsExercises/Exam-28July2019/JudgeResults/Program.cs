using System;
using System.Collections.Generic;
using System.Linq;


namespace JudgeResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> allResult = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                List<string> data = input.Split(new[] { "<>" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (data[0] == "ban")
                {
                    string userName = data[1];
                    allResult.Remove(userName);
                }
                else
                {
                    string userName = data[0];
                    int points = int.Parse(data[1]);

                    if (!allResult.ContainsKey(userName))
                    {
                        allResult[userName] = points;
                    }
                    else
                    {
                        if (allResult[userName] < points)
                        {
                            allResult[userName] = points;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");

            foreach (KeyValuePair<string, int> user in allResult.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }
        }
    }
}
