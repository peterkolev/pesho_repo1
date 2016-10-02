using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class math_power
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(num,pow));

        }
        static double RaiseToPower(double number, int power)
        {
            double result = 1d;
            if (power == 0) 
            { 
            return result = 1.0;
            }
            else
            {
                for (int i = 1; i <=power; i++)
                {
                    result *=number;
                }
                return result;
            }
           
        }
    }
}
