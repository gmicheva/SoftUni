using System;
using System.Collections.Generic;
using System.Linq;


namespace Closest_Two_Points
{
    class Point
    {
        public double X;
        public double Y;
    }
    class Program
    {
        static double CalcDistanceBetweenTwoPoints(Point point1, Point point2)
        {
            double sideA = Math.Abs(point1.X - point2.X);
            double sideB = Math.Abs(point1.Y - point2.Y);
            double sideC = sideA * sideA + sideB * sideB;
            double distance = Math.Sqrt(sideC);
            return distance;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                Point currentPoint = new Point();
                currentPoint.X = input[0];
                currentPoint.Y = input[1];
                points.Add(currentPoint);
            }
            double minDistance = double.MaxValue;
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;

           
            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    double distance = CalcDistanceBetweenTwoPoints(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        x1 = points[i].X;
                        y1 = points[i].Y;
                        x2 = points[j].X;
                        y2 = points[j].Y;
                    }
                }
            }
            Console.WriteLine($"{ minDistance: 0.000}");
            Console.WriteLine($"({x1}, {y1})");
            Console.WriteLine($"({x2}, {y2})");
        }
    }
}
