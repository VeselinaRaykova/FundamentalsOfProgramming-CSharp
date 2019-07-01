using System;
using System.Linq;

namespace _15DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            Point pointB = new Point(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            double distance = CalculateDistance(pointA, pointB);
            Console.WriteLine($"{distance:f3}");
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(a * a + b * b);

            return distance;
        }
    }

    public class Point
    {
        private int x;
        private int y;

        public Point(int[] inputArr)
        {
            this.x = inputArr[0];
            this.y = inputArr[1];
        }
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}
