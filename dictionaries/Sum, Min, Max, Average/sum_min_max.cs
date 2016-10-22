// 3.	Sum, Min, Max, Average from Dictionaries, Lambda and LINQ Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni.19.10.2016
//Task: Write a program to read n integers and print their sum, min, max, first, last and average values.
//Input	Output
//5
//12
//20
//-5
//37
//8	    Sum = 72
//      Min = -5
//      Max = 37
//      Average = 14.4
//4
//50
//20
//25
//40	Sum = 135
//      Min = 20
//      Max = 50
//      Average = 33.75
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__Min__Max__Average
{
    class sum_min_max
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
