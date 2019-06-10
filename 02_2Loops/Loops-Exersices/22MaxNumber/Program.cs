using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int currNum = int.Parse(Console.ReadLine());
        int max = currNum;

        for (int i = 1; i < n; i++)
        {
            currNum = int.Parse(Console.ReadLine());
            if (currNum > max)
            {
                max = currNum;
            }
        }

        Console.WriteLine(max);
    }
}
