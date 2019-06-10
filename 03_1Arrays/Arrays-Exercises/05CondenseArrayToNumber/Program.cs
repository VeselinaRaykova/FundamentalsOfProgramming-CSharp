using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensedArr = new int[initialArr.Length - 1];

            if (initialArr.Length == 1)
            {
                Console.WriteLine(initialArr[0]);
            }
            else
            {

                while (initialArr.Length > 2)
                {
                    for (int i = 0; i < condensedArr.Length; i++)
                    {
                        condensedArr[i] = initialArr[i] + initialArr[i + 1];
                    }
                    initialArr = condensedArr;
                    condensedArr = new int[initialArr.Length - 1];
                }

                Console.WriteLine($"{initialArr[0] + initialArr[1]}");
            }

        }
    }
}
