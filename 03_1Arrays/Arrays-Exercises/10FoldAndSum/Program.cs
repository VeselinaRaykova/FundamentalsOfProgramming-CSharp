using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
                Console.ReadLine()
                .Split(' ').Where(x => !string.IsNullOrEmpty(x))
                .Select(int.Parse)
                .ToArray();
            int k = numbers.Length / 4;
            int[] left = new int[k];
            int[] middle = new int[2 * k];
            int[] right = new int[k];
            int[] reversedLeft = new int[k];
            int[] reversedRight = new int[k];
            int[] sum = new int[2 * k];

            for (int i = 0; i < numbers.Length; i++) //4
            {
                if (i < k) //left Part
                {
                    left[i] = numbers[i];
                }
                else if (i >= k && i < 3 * k) //middle part
                {
                    middle[i - k] = numbers[i];
                }
                else //right part
                {
                    right[i - 3 * k] = numbers[i];
                }
            }

            for (int i = 0; i < k; i++)
            {
                reversedLeft[i] = left[k - 1 - i];
                reversedRight[i] = right[k - 1 - i];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                if (i < k)
                {
                    sum[i] = reversedLeft[i] + middle[i]; //leftNums[k - i]
                }
                else
                {
                    sum[i] = reversedRight[i - k] + middle[i]; //rightNums[i - k]
                }
            }

            Console.WriteLine(string.Join(" ", sum));


        }
    }
}
