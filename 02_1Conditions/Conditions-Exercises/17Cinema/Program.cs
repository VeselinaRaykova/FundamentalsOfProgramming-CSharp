using System;

class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        decimal price = 0;


        if (type == "premiere")
        {
            price = 12m;
        }
        else if (type == "normal")
        {
            price = 7.50m;
        }
        else if (type == "discount")
        {
            price = 5m;
        }
        Console.WriteLine("{0:f2}", price * rows * cols);

    }
}

