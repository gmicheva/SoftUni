using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsofCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();
            char[] stringSeparators = { ':', ' ', ',' };

            List<string> input = userinput.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, int> cards = new Dictionary<string, int>();
            List<int> hands = new List<int>();

            while (input[0] != "JOKER")
            {
                string name = input[0];

                for (int i = 1; i < input.Count; i++)
                {
                    int handPower = 0;
                    int handValue = 0;

                    if (input[i].Contains('S'))
                    {
                        handPower = 4;
                    }
                    else if (input[i].Contains('H'))
                    {
                        handPower = 3;
                    }
                    else if (input[i].Contains('D'))
                    {
                        handPower = 2;
                    }
                    else if (input[i].Contains('C'))
                    {
                        handPower = 1;
                    }

                    if (input[i].Contains('J'))
                    {
                        handValue = 11;
                    }
                    else if (input[i].Contains('Q'))
                    {
                        handValue = 12;
                    }
                    else if (input[i].Contains('K'))
                    {
                        handValue = 13;
                    }
                    else if (input[i].Contains('A'))
                    {
                        handValue = 14;
                    }
                    else
                    {
                        string oneHand = input[i];
                        char first = oneHand[0];
                        handValue = first - 48;
                    }

                    int valueOfoneHand = handValue * handPower;
                    hands.Add(valueOfoneHand);
                }

                int sumHands = hands.Sum();

                if (cards.ContainsKey[name])
                {
                    cards[name] += sumHands;
                }
                else
                {
                    cards[name] = sumHands;
                }

                input = Console.ReadLine().Split(' ').ToList();
            }

            foreach (var item in cards)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
