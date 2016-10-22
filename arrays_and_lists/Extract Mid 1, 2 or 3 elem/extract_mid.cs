//9. Extract Middle 1, 2 or 3 Elements from exercises and homework for the “Programming Fundamentals” course @ SoftUni 11.10.2016
//Condition:Write a method to extract the middle 1, 2 or 3 elements from array of n integers and print them.
//•	n = 1 -> 1 element
//•	even n -> 2 elements
//•	odd n -> 3 elements
//Create a program that reads an array of integers(space separated values) and prints the middle elements in the format shown in the examples.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Mid_1__2_or_3_elem
{
    class extract_mid
    {
        static void Main(string[] args)
        {
            int[] arrInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (arrInput.Length == 1) Console.WriteLine(" {0} ", arrInput[0]);

            else if (arrInput.Length%2==0)
            {
                Console.WriteLine(" {0}, {1} ", arrInput[arrInput.Length/2-1],arrInput[arrInput.Length/2]);
            }
            else Console.WriteLine(" {0}, {1}, {2}", arrInput[arrInput.Length / 2 - 1], arrInput[arrInput.Length / 2], arrInput[arrInput.Length / 2+1]);
        }
    }
    
}
