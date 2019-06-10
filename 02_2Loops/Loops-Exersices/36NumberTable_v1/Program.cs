using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36NumberTable_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col <= n; col++)
                {
                    Console.Write($"{col} ");
                }
                if (row != 1)
                {
                    for (int num = n - 1; num > n - row; num--) //num >= n - row + 1
                    {
                        Console.Write($"{num} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
