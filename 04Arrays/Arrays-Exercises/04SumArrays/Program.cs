using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstLenght = firstArr.Length;

            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int secondLenght = secondArr.Length;

            int n = Math.Max(firstLenght, secondLenght);
            int[] resultArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                resultArr[i] = firstArr[i % firstLenght] + secondArr[i % secondLenght];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
