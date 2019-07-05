using System;
using System.Linq;

namespace _18IntersectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            Circle circle2 = new Circle(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            if (Intersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
                return;
            }

            Console.WriteLine("No");
        }

        static bool Intersect(Circle c1, Circle c2)
        {

            double distanceBetweenCenters = GetDistance(c1.Center, c2.Center);
            double commonDiameter = c1.Radius + c2.Radius;
            if (distanceBetweenCenters <= commonDiameter)
            {
                return true;
            }

            return false;
        }

        private static double GetDistance(Point p1, Point p2)
        {
            double sideA = Math.Abs(p1.X - p2.X);
            double sideB = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);

            return distance;
        }
    }
    public class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Circle(int[] input)
        {
            this.Center = new Point(X: input[0], Y: input[1]);
            this.Radius = input[2];
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

    }
}
