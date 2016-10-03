//9. Longer Line from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 03.10.2016
// Condtion: You are given the coordinates of four points in the 2D plane. The first and the second pair of points form two different lines. Print the longer line in format "(X1, Y1)(X2, Y2)" starting with the point that is closer to the center of the coordinate system (0, 0) (You can reuse the method that you wrote for the previous problem). If the lines are of equal length, print only the first one.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class longer_line
    {
        static void Main(string[] args)
        {
            //first line
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            //second line
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineDistance = GetDistancebetween2Points(x1, y1, x2, y2);
            double secondtLineDistance = GetDistancebetween2Points(x3, y3, x4, y4);
            if (firstLineDistance >= secondtLineDistance)
            {
                PrintLine(x1, y1, x2, y2);
            }
            else PrintLine(x3, y3, x4, y4);
        }

        private static void PrintLine(double x1, double y1, double x2, double y2)
        {
            double distanceToCenter1 = GetDistancebetween2Points(x1, y1, 0, 0);
            double distanceToCenter2 = GetDistancebetween2Points(x2, y2, 0, 0);
            if (distanceToCenter1 <= distanceToCenter2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }

        static double GetDistancebetween2Points(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }
    }
}
