//3. Last K Numbers Sums Sequence from Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni 10.10.2016
//Condition: Write a program to read an array of integers, reverse it and print its elements. The input consists of a number n (the number of elements) + n integers, each as a separate line. Print the output on a single line (space separated).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums_Seque
{
    class last_k_num
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            
            long[] arr = new long[n];
            arr[0] = 1;
            for (long i = 1; i < n; i++)
            {
                arr[i] = SumNums(arr,i - k, i - 1);
            }
           
            Console.WriteLine(string.Join(" ", arr));
        }

        private static long SumNums(long[] arr, long startIndex, long endIndex)
        {
            long sum=0;
            for (long i = startIndex; i <= endIndex; i++)
            {
                if (i >= 0) sum += arr[i]; 
            }
            return sum;
        }
    }
}
