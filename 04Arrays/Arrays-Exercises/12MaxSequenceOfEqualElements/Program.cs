using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int maxCount = 1;
            int counter = 1;
            int numberToPrint = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        numberToPrint = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(numberToPrint + " ");
            }
            Console.WriteLine();

        }
    }
}
