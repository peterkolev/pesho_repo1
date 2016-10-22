//11. Append Lists from exercises and homework for the “Programming Fundamentals” course @ SoftUni 13.10.2016
//Condition:Write a program to append several lists of numbers.
//	Lists are separated by ‘|’.
//	Values are separated by spaces(‘ ’, one or several)
//	Order the lists from the last to the first, and their values from left to right.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_Lists
{
    class append_lists
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> appendedLists = new List<string>();
            for (int i = input.Length-1; i >= 0; i--)

            {
                appendedLists.Add(input[i]);

            }
            for (int i = 0; i <appendedLists.Count; i++)
            {
               string[] appended =appendedLists[i].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
               Console.Write(string.Join(" ", appended));
               Console.Write(' ');
            }
          
        }
    }
}
