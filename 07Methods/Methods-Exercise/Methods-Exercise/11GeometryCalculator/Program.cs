using System;

namespace _11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            double area = CalculateArea(figure);

            Console.WriteLine($"{area:f2}");
        }

        static double CalculateArea(string figure)
        {
            double area = 0;

            switch (figure)
            {

                case "triangle": area = GetTriangleArea(); break;
                case "square": area = GetSquareArea(); break;
                case "rectangle": area = GetRectangleArea(); break;
                case "circle": area = GetCircleArea(); break;
                default:
                    break;
            }
            return area;
        }

        private static double GetTriangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;
            return area;
        }

        private static double GetSquareArea()
        {
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            return area;
        }

        private static double GetRectangleArea()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = a * b;
            return area;
        }

        private static double GetCircleArea()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            return area;
        }
    }
}
