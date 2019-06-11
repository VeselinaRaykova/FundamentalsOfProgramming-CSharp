using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int index = -1; //to be out of the array indexes

            for (int num = 0; num < numbers.Length; num++)
            {
                for (int leftNum = 0; leftNum < num; leftNum++)
                {
                    leftSum += numbers[leftNum];
                }
                for (int rightNum = numbers.Length - 1; rightNum > num; rightNum--)
                {
                    rightSum += numbers[rightNum];
                }
                if (leftSum == rightSum)
                {
                    index = num;
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }

            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
