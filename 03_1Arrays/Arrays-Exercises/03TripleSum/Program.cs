using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isTrue = false;
            int sum = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    foreach (int item in arr)
                    {
                        if (item == sum)
                        {
                            Console.WriteLine($"{arr[i]} + {arr[j]} == {item}");
                            isTrue = true;
                            continue;
                        }
                    }
                }
            }


            if (!isTrue)
            {
                Console.WriteLine("No");
            }
        }
    }
}
