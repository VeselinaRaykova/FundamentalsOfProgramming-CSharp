using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bomb = arr[0];
            int bombPower = arr[1];

            while (numbers.Contains(bomb))
            {
                List<int> temp = new List<int>();
                int bombIndex = numbers.IndexOf(bomb);

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i < bombIndex - bombPower || i > bombIndex + bombPower)
                    {
                        temp.Add(numbers[i]);
                    }
                }
                numbers = temp;
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
