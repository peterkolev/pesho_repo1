//7. Sum Arrays from exercises and homework for the “Programming Fundamentals” course @ SoftUni 11.10.2016
//Condition:Write a program that reads two arrays of integers and sums them. When the arrays are not of the same size, duplicate the smaller array a few times
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class sum_arrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = Math.Max(arr1.Length, arr2.Length);
            int[] result = new int[len];

            for (int i = 0; i < len; i++)
            {
                result[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
