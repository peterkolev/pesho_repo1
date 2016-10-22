//1. Count Real Numbers from Dictionaries, Lambda and LINQ Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni.18.10.2016
//Condtions: Read a list of real numbers and print them in ascending order along with their number of occurrences.
//Input	                Output
//8 2.5 2.5 8 2.5	    2.5 -> 3 times
//                      8 -> 2 times

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    class count_real_num
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            //nums.Sort();
           SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (double num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else counts[num] = 1;   
            }
            foreach (KeyValuePair<double, int> pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
