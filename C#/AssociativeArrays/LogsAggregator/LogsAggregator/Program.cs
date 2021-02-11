using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> logsAgregator = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < number; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                string ip = input[0];
                string name = input[1];
                int logs = int.Parse(input[2]);

                if (!logsAgregator.ContainsKey(name))
                {
                    logsAgregator[name] = new Dictionary<string, int>();
                }

                if (!logsAgregator[name].ContainsKey(ip))
                {
                    logsAgregator[name].Add(ip, logs);
                }

                else
                {
                    logsAgregator[name][ip] += logs;
                }
            }

            foreach (var item in logsAgregator.OrderBy(x => x.Key))
            {
                int totalLogs = logsAgregator[item.Key].Values.Sum();
                List<string> ipList = item.Value.Keys.ToList();
                ipList.Sort();
                Console.WriteLine($"{item.Key}: {totalLogs} [{string.Join(", ", ipList)}]");
            }
        }
    }
}
