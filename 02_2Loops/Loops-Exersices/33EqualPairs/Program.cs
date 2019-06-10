using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int oldSum = firstNum + secondNum;
        int currSum = oldSum;
        int maxDiff = 0;
        int currDiff = 0;

        for (int i = 1; i < n; i++)
        {
            firstNum = int.Parse(Console.ReadLine());
            secondNum = int.Parse(Console.ReadLine());

            currSum = firstNum + secondNum;
            if (currSum != oldSum)
            {
                currDiff = Math.Abs(oldSum - currSum);
                if (currDiff > maxDiff)
                {
                    maxDiff = currDiff;
                }
            }
            oldSum = currSum;
        }

        if (maxDiff > 0)
        {
            Console.WriteLine($"No, maxdiff={maxDiff}");
        }
        else //All sums are quea
        {
            Console.WriteLine($"Yes, value={oldSum}");
        }


    }
}
