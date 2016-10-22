//4.	Distance Between Points  from Objects and Classes Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni. 21.10.2016
//task:Write a method to calculate the distance between two points p1 {x1, y1} and p2 {x2, y2}. Write a program to read two points (given as two integers) and print the Euclidean distance between them.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Points
{
    class distance_betw_points
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            double distance = CalcDistance(p1, p2);
            Console.WriteLine(distance);

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

    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
