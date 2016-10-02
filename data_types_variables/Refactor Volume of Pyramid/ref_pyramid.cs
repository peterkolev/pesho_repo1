using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Pyramid
{
    class ref_pyramid
    {
        static void Main(string[] args)
        {
            double length, width, hight;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            hight = double.Parse(Console.ReadLine());
            double volume = (length * width * hight) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
