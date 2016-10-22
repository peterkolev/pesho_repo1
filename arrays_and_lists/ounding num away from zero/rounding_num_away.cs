//5. Rounding Numbers Away from Zero for exercises and homework for the “Programming Fundamentals” course @ SoftUni 09.10.2016
//Condition: Write a program to read an array of real numbers (space separated values), round them to the nearest integer in “away from 0” style and print the output as in the examples below
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rounding_num_away_from_zero
{
    class rounding_num_away
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            double[] numsDouble = new double[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numsDouble[i] = double.Parse(nums[i]);
            }
            int[] numsInt = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numsInt[i] = (int)Math.Round(numsDouble[i],MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numsDouble[i]} -> {numsInt[i]}");
            }
            
        }
    }
}
