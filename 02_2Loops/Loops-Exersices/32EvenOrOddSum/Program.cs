using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int number = 0;
        int oddSum = 0; //1, 3, 4
        int evenSum = 0;
        int diff = 0;
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += number;
            }
            else
            {
                oddSum += number;
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {oddSum}");
        }
        else
        {
            diff = Math.Abs(oddSum - evenSum);
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {diff}");
        }

    }
}
