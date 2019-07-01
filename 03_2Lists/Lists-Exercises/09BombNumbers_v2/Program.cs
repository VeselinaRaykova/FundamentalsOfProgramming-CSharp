using System;
using System.Collections.Generic;
using System.Linq;

namespace _09BombNumbers_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bomb = arr[0];
            int bombPower = arr[1];

            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);
                int leftIndex = bombIndex - bombPower > 0 ? bombIndex - bombPower : 0;
                int rightIndex = bombIndex + bombPower <= numbers.Count ? bombIndex + bombPower : numbers.Count - 1;

                numbers.RemoveRange(bombIndex, rightIndex - bombIndex + 1);
                numbers.RemoveRange(leftIndex, bombIndex - leftIndex);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
