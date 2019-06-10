using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10FoldAndSum_v2
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
            int[] leftEnd = new int[k];
            int[] middle = new int[2 * k];
            int[] rightEnd = new int[k];
            int[] combinedEnds = new int[2 * k];
            int[] sum = new int[2 * k];

            for (int i = 0; i < numbers.Length; i++) //4
            {
                if (i < k) //left Part
                {
                    leftEnd[i] = numbers[i];
                }
                else if (i >= k && i < 3 * k) //middle part
                {
                    middle[i - k] = numbers[i];
                }
                else //right part
                {
                    rightEnd[i - 3 * k] = numbers[i];
                }
            }

            Array.Reverse(leftEnd);
            Array.Reverse(rightEnd);
            combinedEnds = leftEnd.Concat(rightEnd).ToArray();

            for (int i = 0; i < 2 * k; i++)
            {
                sum[i] = combinedEnds[i] + middle[i];

            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
