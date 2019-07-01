using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (!count.ContainsKey(number))
                {
                    count[number] = 1;
                }
                else
                {
                    count[number]++;
                }
            }

            foreach (var pair in count)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}
