using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08SumReversedNumbers_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(' ')
                .ToList();

            List<int> reversed = new List<int>();

            foreach (string number in numbers)
            {
                reversed.Add(int.Parse(string.Join("", number.ToCharArray().Reverse())));
            }

            Console.WriteLine(reversed.Sum());
        }
    }
}