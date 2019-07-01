using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int maxCount = 1;
            int counter = 1;
            int startPos = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    counter++;

                    if (maxCount < counter)
                    {
                        maxCount = counter;
                        startPos = i - maxCount + 1;
                    }
                }
                else //(numbers[i] <= numbers[i - 1])
                {
                    counter = 1;
                }
            }

            for (int i = startPos; i < startPos + maxCount; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
