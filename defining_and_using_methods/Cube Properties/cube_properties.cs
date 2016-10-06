//10.Cube Properties from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 04.10.2016
//Write a program that can calculate the length of the face diagonals, space diagonals, volume and surface area of a cube (http://www.mathopenref.com/cube.html) by a given side. On the first line you will get the side of the cube. On the second line is given the parameter (face, space, volume or area).
//Output should be rounded to the second digit after the decimal point

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class cube_properties
    {
        static void Main(string[] args)
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string property = Console.ReadLine(). ToLower();
            switch (property)
            {
                case "face": Console.WriteLine($"{ GetFaceDiagonalLenghtOfCube(sideOfCube):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{ GetSpaceDiagonalLengthOfCube(sideOfCube):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{ GetVolumeOfCube(sideOfCube):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{ GetAreaOfCube(sideOfCube):f2}");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
        static double GetFaceDiagonalLenghtOfCube(double a)
        {
            double faceDiagnolLength = Math.Sqrt(a * a*2);
            return faceDiagnolLength;
        }
        static double GetSpaceDiagonalLengthOfCube(double a)
        {
            double spaceDiagnolLength = Math.Sqrt(a * a * 3);
            return spaceDiagnolLength;
        }
        static double GetVolumeOfCube(double a)
        {
            double volume = a * a * a;
            return volume;
        }
        static double GetAreaOfCube(double a)
        {
            double area = a * a * 6;
            return area;
        }
    }
}
