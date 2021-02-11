using System;
using System.Collections.Generic;
using System.Linq;

namespace Intersection_of_Circles
{
    class Circle
    {
        public double X;
        public double Y;
        public double Radius;
    }
    
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Circle> circles = new List<Circle>();

            for (int i = 0; i < 2; i++)
            {
                List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
                Circle currentCircle = new Circle();
                currentCircle.X = input[0];
                currentCircle.Y = input[1];
                currentCircle.Radius = input[2];
                circles.Add(currentCircle);
            }

            if (CircleIntersect(circles[0], circles[1]))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }            
        }

        static double DistanceCircleCenter(Circle c1, Circle c2)
        {
            double sideA = Math.Abs(c1.X - c2.X);
            double sideB = Math.Abs(c1.Y - c2.Y);
            double sideC = sideA * sideA + sideB * sideB;
            double distance = Math.Sqrt(sideC);
            return distance;
        }

        static bool CircleIntersect(Circle c1, Circle c2)
        {
            bool intersect = false;
            double distance = DistanceCircleCenter(c1, c2);
            if (distance <= c1.Radius + c2.Radius)
            {
                intersect = true;
            }
            return intersect;
        }
    }
}
