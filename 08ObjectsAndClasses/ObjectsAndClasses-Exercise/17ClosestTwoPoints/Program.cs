using System;
using System.Collections.Generic;
using System.Linq;

namespace _17ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int pointsCount = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            Point closestPointA = new Point();
            Point closestPointB = new Point();
            double minDistance = int.MaxValue;
            double currDistance = 0;

            for (int i = 0; i < pointsCount; i++)
            {
                Point point = new Point(Console.ReadLine().Split().Select(int.Parse).ToArray());
                points.Add(point);
            }

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int k = i + 1; k < pointsCount; k++)
                {
                    currDistance = CalcDistance(points[i], points[k]);
                    if (currDistance < minDistance)
                    {
                        minDistance = currDistance;
                        closestPointA = points[i];
                        closestPointB = points[k];
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            PrintPoint(closestPointA);
            PrintPoint(closestPointB);
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            double sideA = Math.Abs(p1.x - p2.x);
            double sideB = Math.Abs(p1.y - p2.y);
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            return distance;
        }

        private static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.x}, {point.y})");
        }
    }
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point()
        {
        }

        public Point(int[] coords)
        {
            this.x = coords[0];
            this.y = coords[1];
        }
    }
}
