using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            int minLenght = Math.Min(firstArray.Length, secondArray.Length);
            int leftEnd = 0;
            int rightEnd = 0;

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftEnd++;
                }
                if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
                {
                    rightEnd++;
                }
            }

            Console.WriteLine(Math.Max(leftEnd, rightEnd));
        }
    }
}
