using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "stop playing")
            {
                List<int> data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                HashSet<int> uniqueList = new HashSet<int>();

                foreach (int num in data)
                {
                    uniqueList.Add(num);
                }

                if (data.Count == uniqueList.Count)
                {
                    for (int i = 0; i < data.Count; i ++)
                    {
                        if (data[i] % 2 == 0)
                        {
                            data[i] = data[i] + 2;
                        }
                        
                    }
                    data.Sort();
                    Console.WriteLine($"Unique list: {string.Join(",", data)}");
                     
                    double sum = data.Sum();
                    double lenght = data.Count;
                    double outputDivide = sum / lenght;
                    Console.WriteLine($"Output: {outputDivide:0.00}");

                }
                else
                {
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i] % 2 != 0)
                        {
                            data[i] = data[i] + 3;
                        }
                        
                    }
                    data.Sort();
                    Console.WriteLine($"Non-unique list: {string.Join(":", data)}");

                    double sum = data.Sum();
                    double lenght = data.Count;
                    double outputDivide = sum / lenght;

                    Console.WriteLine($"Output: {outputDivide:0.00}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
