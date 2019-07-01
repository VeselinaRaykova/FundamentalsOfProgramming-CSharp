using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split().Select(char.Parse).ToArray();


            for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    continue;
                }
                else if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine(firstArr);
                    Console.WriteLine(secondArr);
                    return;
                }
                else
                {
                    Console.WriteLine(secondArr);
                    Console.WriteLine(firstArr);
                    return;
                }
            }

            if (firstArr.Length < secondArr.Length)
            {
                Console.WriteLine(firstArr);
                Console.WriteLine(secondArr);
            }
            else
            {
                Console.WriteLine(secondArr);
                Console.WriteLine(firstArr);
            }
        }
    }
}
