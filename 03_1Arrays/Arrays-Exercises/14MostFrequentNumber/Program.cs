using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] numbers = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int maxCount = 0;
            int currCount = 1;
            ushort maxNum = numbers[0]; //if the lenght of all numbers is the same, print the first one
            ushort currNum;

            for (int i = 0; i < numbers.Length; i++)
            {
                currNum = numbers[i];
                currCount = 1;

                for (int k = i + 1; k < numbers.Length; k++) //compare with the numbers till the end of the array
                {
                    if (currNum == numbers[k])
                    {
                        currCount++;
                        if (currCount > maxCount)
                        {
                            maxCount = currCount;
                            maxNum = currNum;
                        }
                    }
                }
            }
            Console.WriteLine(maxNum);

        }
    }
}
