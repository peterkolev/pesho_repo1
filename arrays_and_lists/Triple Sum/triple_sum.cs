//4.	Triple Sumfrom Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni 09.10.2016
//Condition: Write a program to read an array of integers and find all triples of elements a, b and c, such that a + b == c (where a stays left from b). Print “No” if no such triples exist.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple_Sum
{
    class triple_sum
    {
        static void Main(string[] args)
        {
            string[] arrNumbers = Console.ReadLine().Split();
            int[] array = new int[arrNumbers.Length];
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                array[i] = int.Parse(arrNumbers[i]);
            }
            bool checker = true;

            for (int a = 0; a < array.Length-1; a++)
            {
                int firstNumber = array[a];
                for (int b = a+1; b < array.Length; b++)
                {
                    int secondNumber = array[b];
                    int sum = firstNumber + secondNumber;

                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} == {sum}");
                        checker = false;
                    }
                }
            }
            if (checker) Console.WriteLine("No");
        }
    }
}
