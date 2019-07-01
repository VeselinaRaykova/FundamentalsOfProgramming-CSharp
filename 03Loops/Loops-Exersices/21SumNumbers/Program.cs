using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int currNum = 0;

        for (int i = 0; i < n; i++)
        {
            currNum = int.Parse(Console.ReadLine());
            sum += currNum;
        }

        Console.WriteLine(sum);
    }
}
