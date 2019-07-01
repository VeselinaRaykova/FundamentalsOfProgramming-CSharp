using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09RotateAndSum
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
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            //if (k == 1)
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        sum[i] += numbers[i];
            //    }
            //}


            for (int rotatedTimes = 0; rotatedTimes < k; rotatedTimes++)
            {
                int[] rotatedNumbers = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; i++)
                {

                    if (i == 0)
                    {
                        rotatedNumbers[i] = numbers[numbers.Length - 1];

                    }
                    else
                    {
                        rotatedNumbers[i] = numbers[i - 1];
                    }
                    sum[i] += rotatedNumbers[i];
                }
                numbers = rotatedNumbers;
            }

            Console.WriteLine(string.Join(" ", sum));
        }


    }
}