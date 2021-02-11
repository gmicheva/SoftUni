using System;
using System.Collections.Generic;
using System.Linq;

namespace Distance_Between_Points
{
    class Program
    {
        static double CalcEuclideanDistance(int x1, int y1, int x2, int y2 )
        {
            int sideA = Math.Abs(x1 - x2);
            int sideB = Math.Abs(y1 - y2);
            int sideC = sideA * sideA + sideB * sideB;
            double distance = Math.Sqrt(sideC);
            return distance;
        }

        static void Main(string[] args)
        {
            List<int> pointP1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> pointP2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int x1 = pointP1[0];
            int y1 = pointP1[1];
            int x2 = pointP2[0];
            int y2 = pointP2[1];
            double result = CalcEuclideanDistance(x1, y1, x2, y2);
            Console.WriteLine(result);
        }
    }
}
