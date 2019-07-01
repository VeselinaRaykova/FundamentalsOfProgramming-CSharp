using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int numsToSum = int.Parse(Console.ReadLine());
            long[] array = new long[n];

            array[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1; j >= i - numsToSum && j >= 0; j--)
                {
                    array[i] += array[j];
                }
            }

            Console.WriteLine(string.Join(" ", array));
        }

    }
}

