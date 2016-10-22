// 5.	Closest Two Points from Objects and Classes Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni. 22.10.2016
//task:Write a program to read n points and find the closest two of them.
//Input
//The input holds the number of points n and n lines, each holding a point { X and Y coordinate }.
//Output
//•	The output holds the shortest distance and the closest two points.
//•	If several pairs of points are equally close, print the first of them(from top to bottom). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closest_Two_Points
{
    class closest2points
    {
        static void Main(string[] args)
        {
           Point[] points =ReadPoints();
           Point[] closestPoints = GetClosestPoints(points);
           double distance = CalcDistance(closestPoints[0], closestPoints[1]);
            Console.WriteLine("{0:f3}", distance);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }
        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];
            return point;
        }
        static double CalcDistance(Point p1, Point p2)
        {

            double distance = Math.Sqrt((Math.Pow((p1.X - p2.X), 2)) + Math.Pow((p1.Y - p2.Y), 2));
            return distance;
        }
        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }
        static void PrintPoint(Point point)
        {
            Console.WriteLine( "({0}, {1})", point.X, point.Y );
        }
        static Point[] GetClosestPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };
                    }
                }
            return closestTwoPoints;

        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
