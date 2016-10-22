//16. Count Numbersfrom exercises and homework for the “Programming Fundamentals” course @ SoftUni 15.10.2016
//Condition: Read a list of integers in range [0…1000] and print them in ascending order along with their number of occurrences.
//Input             Output
//8 2 2 8 2 2 3 7	2 -> 4
//                  3 -> 1
//                  7 -> 1
//                  8 -> 2
//10 8 8 10 10	    8 -> 2
//                  10 -> 3


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Count_Numbers
{
    class counting_nums
    {
        static void Main(string[] args)
        {
            //int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //int max = nums.Max();
            //int[] counts = new int[max + 1];
            // foreach  (int num in nums)
            // {
            //     counts[num]++;
            // }
            // for (int i = 0; i <counts.Length; i++)
            // {
            //     if (counts[i] > 0) Console.WriteLine($"{i} -> {counts[i]}");
            // }    
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort();
            int counts = 1;
            for (int i = 1; i < nums.Count; i++)
            {
                if ((nums[i-1]==nums[i])||(i==nums.Count-1))
                {
                    counts++;
                    if (i == nums.Count - 1)
                    {
                        
                        Console.WriteLine($"{nums[i]} -> {counts}");
                    }
                    
                }
                else
                {
                    Console.WriteLine($"{nums[i-1]} -> {counts}");
                    
                    counts = 1;
                }
            }
        }
    }
}
