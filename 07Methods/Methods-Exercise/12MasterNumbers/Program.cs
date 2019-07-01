using System;

namespace _12MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (IsMaster(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsMaster(int number)
        {
            bool isMaster = IsSymetric(number) && IsDivisibleBy7(number) && HasEvenDigits(number);
            return isMaster;
        }

        private static bool IsSymetric(int number)
        {
            string num = number.ToString();

            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsDivisibleBy7(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool HasEvenDigits(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
    }
}
