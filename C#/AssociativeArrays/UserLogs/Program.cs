using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            while (input[0] != "end")
            {
                string ip = input[0];
                List<string> ipList = ip.Split('=').ToList();
                string ipOnly = ipList[1];

                int counter = 1;

                string user = input[2];
                List<string> userList = user.Split('=').ToList();
                string userOnly = userList[1];

                if (!data.ContainsKey(userOnly))
                {
                    data[userOnly] = new Dictionary<string, int>();

                }

                if (!data.ContainsKey(ipOnly))
                {
                    data[userOnly].Add(ipOnly, counter);
                }
                else
                {
                    data[userOnly][ipOnly] += counter;
                }

                input = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var ip in item.Value)
                {
                    //List<string> ipList = data.Values
                    Console.WriteLine($"{ip.Key}:{ip.Value}");
                }
            }
        }
    }
}
