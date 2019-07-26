using System;
using System.Collections.Generic;
using System.Linq;

namespace _07HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> powers = new Dictionary<string, int>() {
                {"2", 2}, {"3", 3}, {"4", 4}, {"5", 5},
                {"6", 6}, {"7", 7}, {"8", 8}, {"9", 9}, {"10", 10},
                {"J", 11}, {"Q", 12}, {"K", 13}, {"A", 14}
            };

            Dictionary<string, int> types = new Dictionary<string, int>() {
                { "S", 4},
                { "H", 3},
                { "D", 2},
                { "C", 1}
            };

            Dictionary<string, List<string>> people = new Dictionary<string, List<string>>();

            while (input.ToLower() != "joker")
            {
                string[] inputLine = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = inputLine[0];
                List<string> cards = inputLine[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!people.ContainsKey(name))
                {
                    people[name] = cards.Distinct().ToList();
                }
                else
                {
                    foreach (var card in cards)
                    {
                        if (!people[name].Contains(card))
                        {
                            people[name].Add(card);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                int sum = 0;
                foreach (string card in person.Value.Distinct())
                {
                    string power = "";
                    string type = "";

                    if (card.Length == 2)
                    {
                        power = card[0].ToString();
                        type = card[1].ToString();
                    }
                    else
                    {
                        power = card.Substring(0, 2);
                        type = card[2].ToString();
                    }

                    sum += powers[power] * types[type];
                }

                Console.WriteLine($"{person.Key}: {sum}");
            }

        }
    }
}
