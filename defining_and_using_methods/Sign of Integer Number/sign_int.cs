﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    class sign_int
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printSign(n);
        }
        static void printSign(int number)
        {
            if (number>0)
            {
                Console.WriteLine("The number {0} is positive.",number);
            }
            else if (number<0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else Console.WriteLine("The number 0 is zero.");
        }
    }
}
