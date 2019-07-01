using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int currNum;
        int leftSum = 0;
        int rightSum = 0;
        int diff;

        for (int i = 0; i < n; i++)
        {
            currNum = int.Parse(Console.ReadLine());
            leftSum += currNum;
        }

        for (int i = n; i < n * 2; i++)
        {
            currNum = int.Parse(Console.ReadLine());
            rightSum += currNum;
        }

        diff = Math.Abs(leftSum - rightSum);
        if (diff == 0)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {diff}");
        }
    }
}
