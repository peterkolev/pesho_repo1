//6. Rectangle Position from Objects and Classes Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni. 22.10.2016
//task:Write a program to read two rectangles {left, top, width, height} and print whether the first is inside the second.
//The input is given as two lines, each holding a rectangle, described by 4 integers: left, top, width and height.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Position
{
    class rectangle_pos
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = ReadRectangle();
            Rectangle rect2 = ReadRectangle();
            Console.WriteLine(rect1.IsInside(rect2) ? "Inside" : "Not inside" );

        }
        static Rectangle ReadRectangle()
        {
            int[] rectangleInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rect = new Rectangle();
            rect.Top = rectangleInfo[0];
            rect.Left = rectangleInfo[1];
            rect.Width = rectangleInfo[2];
            rect.Height = rectangleInfo[3];
            return rect;
        }
    }
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) &&
               (r.Top <= Top) && (r.Bottom >= Bottom);
        }

    }
}
