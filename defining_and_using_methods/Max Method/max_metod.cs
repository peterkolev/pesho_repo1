using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class max_metod
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(GetMax(a, b), c));

        }
        static int GetMax(int x, int y)
        {
            if (x >= y)
            {
                return x;
            }
            else return y;
        }
    }
}
