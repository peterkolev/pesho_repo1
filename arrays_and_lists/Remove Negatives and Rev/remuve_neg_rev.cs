//10.	Remove Negatives and Reverse from exercises and homework for the “Programming Fundamentals” course @ SoftUni 11.10.2016
//Condition:Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. In case of no elements left in the list, print “empty”
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Negatives_and_Rev
{
    class remuve_neg_rev
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> positiveRev = new List<int>();
            for (int i = numbers.Count-1; i >= 0 ; i--)
            {
                if ((numbers[i]) > 0)
                {
                    positiveRev.Add(numbers[i]);
                }
            }
            if (positiveRev.Count == 0) Console.WriteLine("empty");
            else Console.WriteLine(string.Join(" ",positiveRev));

        }
    }
}
