using System;
using System.Numerics;

namespace _14FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = Factorial(n);
            Console.WriteLine(CountZeroes(factorial));
        }

        private static int CountZeroes(BigInteger factorial)
        {
            int count = 0;
            while (factorial != 0)
            {
                if (factorial % 10 == 0)
                {
                    count++;
                }
                else
                {
                    return count;
                }
                factorial /= 10;
            }
            return count;
        }

        private static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
