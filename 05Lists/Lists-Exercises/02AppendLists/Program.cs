using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            List<int> result = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                result.AddRange(input[i]
                    //.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Split().Where(x => !string.IsNullOrEmpty(x))
                    .Select(int.Parse)
                    .ToList());
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
