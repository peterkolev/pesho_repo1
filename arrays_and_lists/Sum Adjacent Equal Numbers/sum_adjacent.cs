//12.	Sum Adjacent Equal Numbers from exercises and homework for the “Programming Fundamentals” course @ SoftUni 14.10.2016
//Condition:Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
//	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well(see the examples below).
//	Always sum the leftmost two equal neighbors(if several couples of equal neighbors are available).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Adjacent_Equal_Numbers
{
    class sum_adjacent
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i-1]==nums[i])
                {
                    nums[i-1] +=nums[i];
                    nums.RemoveAt(i);
                    i--;
                    if (i>0)
                    {
                        i--;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", nums));


        }
    }
}
