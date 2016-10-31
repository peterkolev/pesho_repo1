//2. Count substring occurrences from Strings and RegEx - Lab 25.10.2016
//Condition:Write a program to find how many times a given string appears in a given text as substring. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the character casing. Overlapping between occurrences is allowed.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substracting_str
{
    class substracting_str
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToLower();
            string stringForCheck = Console.ReadLine().ToLower();
            int count = 0;
            int index = inputString.IndexOf(stringForCheck,0);
            
            while(index!=-1)
            {
                count++;
                index = inputString.IndexOf(stringForCheck, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
