using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class calc_tri_area
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width,height);
            Console.WriteLine(area);
        }
        static double GetTriangleArea(double width, double height)
        {
            return width* height / 2;         
        }
    }
}
