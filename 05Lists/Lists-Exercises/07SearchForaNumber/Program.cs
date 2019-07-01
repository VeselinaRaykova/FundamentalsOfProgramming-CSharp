using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SearchForaNumber
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
            int numsToTake = arr[0];  //start from numbers[0]
            int numsToDelete = arr[1]; //start from numsToTake[0]
            int numToSearch = arr[2];

            List<int> result = numbers
                .Take(numsToTake)
                .Skip(numsToDelete)
                .ToList();

            //option 2
            //List<int> result = numbers.GetRange(0, numsToTake);
            //result.RemoveRange(0, numsToDelete);

            if (result.Contains(numToSearch))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }

        }
    }
}
