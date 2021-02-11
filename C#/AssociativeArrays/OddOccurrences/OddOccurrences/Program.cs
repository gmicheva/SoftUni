using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            words = words.ConvertAll(x => x.ToLower());
            Dictionary<string, int> occurance = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];
                List<string> occurateWord = words.Where(x => x == currentWord).ToList();
                int occurateCount = occurateWord.Count;

                if (occurateCount % 2 != 0)
                {
                    occurance[currentWord] = occurateCount;
                }
            }

            List<string> oddWord = new List<string>();

            foreach (KeyValuePair<string, int> item in occurance)
            {
                oddWord.Add(item.Key);
            }

            Console.WriteLine(string.Join(", ", oddWord));
        }
    }
}
