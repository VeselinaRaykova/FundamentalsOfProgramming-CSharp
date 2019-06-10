using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int number = int.Parse(Console.ReadLine());
        int minNumber = number;

        for (int i = 1; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (number < minNumber)
            {
                minNumber = number;
            }
        }

        Console.WriteLine(minNumber);
    }
}
