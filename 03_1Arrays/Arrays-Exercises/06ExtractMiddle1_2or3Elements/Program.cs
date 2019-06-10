using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExtractMiddle1_2or3Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = array.Length;
            int[] resultArr;

            if (n <= 1)
            {
                resultArr = array;
            }
            else if (n % 2 == 0) //2 3 8 1 7 4
            {
                resultArr = new int[] { array[n / 2 - 1],
                                            array[n / 2] };
            }
            else //1 2 3 4 5 6 7    7/2=>3
            {
                resultArr = new int[] { array[n / 2 - 1],
                                            array[n / 2],
                                            array[n / 2 + 1] };
            }

            Console.WriteLine("{ " + string.Join(", ", resultArr) + " }");
        }
    }
}
