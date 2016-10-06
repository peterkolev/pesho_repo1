//11. Geometry Calculator from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 04.10.2016
//Condition:Write a program that can calculate the area of four different geometry figures - triangle, square, rectangle and circle.On the first line you will get the figure type. Next you will get parameters for the chosen figure, each on a different line:
// •Triangle - side and height
//•	Square - side
//•	Rectangle - width and height
//•	Circle - radius
//The output should be rounded to the second digit after the decimal point.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator
{
    class geometry_calc
    {
        static void Main(string[] args)
        {
            string typeOfFugre = Console.ReadLine().ToLower();
            double area=0;
            if (typeOfFugre == "triangle") area = GetAreaOfTriangle(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            else if (typeOfFugre == "square") area = GetAreaOfSquare(Double.Parse(Console.ReadLine()));
            else if (typeOfFugre == "rectangle") area = GetAreaOfRectangle(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            else if (typeOfFugre == "circle") area = GetAreaOfCircle(Double.Parse(Console.ReadLine()));
            else Console.WriteLine("Wrong input");
            Console.WriteLine("{0:f2}",area);
        }
        static double GetAreaOfTriangle(double side, double height)
        {
            return side * height / 2;
        }
        static double GetAreaOfSquare(double side)
        {
            return side * side;
        }
        static double GetAreaOfRectangle(double side1, double side2)
        {
            return side1 * side2;
        }
        static double GetAreaOfCircle(double radius)
        {
            return Math.PI*radius*radius;
        }
    }
}
