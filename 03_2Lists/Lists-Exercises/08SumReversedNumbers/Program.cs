using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(' ')
                .ToList();

            int sum = 0;
            foreach (string number in numbers)
            {
                char[] numberArr = number.ToCharArray();
                numberArr = numberArr.Reverse().ToArray();
                int reversedNum = int.Parse(string.Join("", numberArr));
                sum += reversedNum;
            }

            Console.WriteLine(sum);
        }
    }
}
