using System;

namespace _10CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstDistance = GetDistanceToZero(x1, y1);
            double secondDistance = GetDistanceToZero(x2, y2);

            PrintCloserPoint(firstDistance, secondDistance, x1, y1, x2, y2);

        }

        private static void PrintCloserPoint(double firstDistance, double secondDistance, double x1, double y1, double x2, double y2)
        {
            if (firstDistance <= secondDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        static double GetDistanceToZero(double x, double y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }
    }
}
