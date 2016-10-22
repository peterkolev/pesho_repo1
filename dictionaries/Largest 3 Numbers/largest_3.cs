//4.Largest 3 Numbers from Dictionaries, Lambda and LINQ Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni.20.10.2016
//Task:Read a list of real numbers and print largest 3 of them. If less than 3 numbers exit, print all of them.
//Input	                Output
//10 30 15 20 50 5	    50 30 20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Numbers
{
    class largest_3
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(number => double.Parse(number)).OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
