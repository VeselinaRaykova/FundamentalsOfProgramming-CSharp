using System;

class Program
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        double perimeter = 2 * Math.PI * r;

        Console.WriteLine(String.Format("{0:0.0000}", area));
        Console.WriteLine(String.Format("{0:0.0000}", perimeter));
    }
}
