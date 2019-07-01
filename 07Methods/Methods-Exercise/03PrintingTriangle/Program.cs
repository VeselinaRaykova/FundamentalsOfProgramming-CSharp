using System;

namespace _03PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTriangle(number);
        }

        private static void PrintTriangle(int num)
        {
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }

            for (int row = 1; row < num; row++)
            {
                for (int col = 1; col <= num-row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();

            }
        }
    }
}
