using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    //Math.Abs(numbers[i] - numbers[j]== diff) seems to be slow -> timeout
                    if (numbers[i] - numbers[j]== diff || numbers[i] - numbers[j] == -diff)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
