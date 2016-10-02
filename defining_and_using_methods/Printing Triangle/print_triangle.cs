using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class print_triangle
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           // PrintLine(1, n);
            PrintTriangle(n);
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }


    }
}
