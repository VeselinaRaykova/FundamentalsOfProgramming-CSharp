using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split(' ').ToArray();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            List<string> result = new List<string>();

            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount[word] = 1;
                }
            }

            foreach (var pair in wordsCount)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
