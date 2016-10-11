//08. Condense Array to Number from exercises and homework for the “Programming Fundamentals” course @ SoftUni 11.10.2016
//Condition: Write a program to read an array of integers and condense them by summing adjacent couples of elements until a single integer is obtained. For example, if we have 3 elements {2, 10, 3}, we sum the first two and the second two elements and obtain {2+10, 10+3} = {12, 13}, then we sum again all adjacent elements and obtain {12+13} = {25}.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class condese_arr
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while (nums.Length > 1)
            {
                var result = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length-1; i++)
                {
                    result[i] = nums[i] + nums[i + 1];
                }
                nums = result;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
