using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxNumer = GetMax(GetMax(a, b), c);

            Console.WriteLine(maxNumer);
        }

        private static int GetMax(int a, int b)
        {
            int max = a > b ? a : b;
            return max;
        }
    }
}
