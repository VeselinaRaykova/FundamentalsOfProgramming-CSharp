using System;

namespace _04CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = CalculateArea(side, height);

            Console.WriteLine(area);
        }

        private static double CalculateArea(double side, double height)
        {
            double area = side * height / 2;
            return area;
        }
    }
}
