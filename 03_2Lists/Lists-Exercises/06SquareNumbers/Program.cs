using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> squares = new List<int>();

            foreach (int num in numbers)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    squares.Add(num);
                }
            }

            squares.Sort();
            squares.Reverse();
            //squares.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
