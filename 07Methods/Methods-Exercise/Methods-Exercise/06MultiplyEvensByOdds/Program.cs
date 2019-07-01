using System;

namespace _06MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int multiple = GetMultipleOfEvensAndOdds(number);

            Console.WriteLine(multiple);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int result = 0;
            int oddSum = 0;
            int evenSum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
                number /= 10;
            }
            result = evenSum * oddSum;
            return result;

        }
    }
}
