//8. Center Point from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 03.10.2016
// Condtion:You are given the coordinates of two points on a Cartesian coordinate system - X1, Y1, X2 and Y2. Create a method that prints the point that is closest to the center of the coordinate system (0, 0) in the format (X, Y). If the points are on a same distance from the center, print only the first one.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class center_point
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distanceToCenter1 = GetDistancebetween2Points(x1, y1, 0, 0);
            double distanceToCenter2 = GetDistancebetween2Points(x2, y2, 0, 0);
            if (distanceToCenter1 <= distanceToCenter2) Console.WriteLine($"({x1}, {y1})");
            else Console.WriteLine($"({x2}, {y2})");

        }
        static double GetDistancebetween2Points(double x1,double y1,double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}
