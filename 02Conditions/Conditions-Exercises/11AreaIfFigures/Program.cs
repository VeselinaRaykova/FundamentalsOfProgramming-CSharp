using System;

class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        double area = 0;

        if (type == "square")
        {
            double a = double.Parse(Console.ReadLine());
            area = a * a;
        }
        else if (type == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            area = a * b;
        }
        else if (type == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            area = Math.PI * r * r;
        }
        else if (type == "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            area = a * h / 2;
        }
        Console.WriteLine(Math.Round(area, 3));
    }
}