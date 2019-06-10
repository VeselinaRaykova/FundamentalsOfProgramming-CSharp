using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string result = "Prime";

        if (n < 2)
        {
            result = "Not prime";
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    result = "Not prime";
                    break;
                }
            }
        }
        
        Console.WriteLine(result);
    }
}
