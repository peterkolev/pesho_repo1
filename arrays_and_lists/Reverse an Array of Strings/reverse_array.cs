//6. Reverse an Array of Strings for exercises and homework for the “Programming Fundamentals” course @ SoftUni 10.10.2016
//Condition: Write a program to read an array of strings, reverse it and print its elements. The input consists of a sequence of space separated strings. Print the output on a single line (space separated).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Strings
{
    class reverse_array
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] straitArr = input.Split(' ');
            string[] mirrorArr = new string[straitArr.Length];
            for (int i = 0; i < straitArr.Length; i++)
            {
                mirrorArr[i] = straitArr[((straitArr.Length - 1) - i)];
            }
            for (int j = 0; j < mirrorArr.Length; j++)
            {
                Console.Write($"{mirrorArr[j]} ");
            }
            Console.WriteLine();
        }
    }
}
