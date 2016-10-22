//2. Reverse an Array of Integers from Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni 08.10.2016
//Condition: Write a program to read an array of integers, reverse it and print its elements. The input consists of a number n (the number of elements) + n integers, each as a separate line. Print the output on a single line (space separated).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse__an_array_of_int
{
    class reverse_array
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int [n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-1; i >=0; i--)
            {
                Console.Write($"{arr[i]} ");
            }

        }
    }
}
