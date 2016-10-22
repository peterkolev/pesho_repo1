//14.Sort Numbers from exercises and homework for the “Programming Fundamentals” course @ SoftUni 15.10.2016
//Condition:Read a list of decimal numbers and sort them in increasing order. Print the output as shown in the examples below.
//Input	    Output
//8 2 7 3	2 <= 3 <= 7 <= 8
//2 4 -9	-9 <= 2 <= 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers
{
    class sort_numbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ",numbers));
        }
    }
}
