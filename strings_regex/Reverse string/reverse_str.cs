//1. Reverse string from Strings and RegEx - Lab 25.10.2016
//Condition: Write a program that reads a string from the console, reverses it and prints the result back at the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_string
{
    class reverse_str
    {
        static void Main(string[] args)
        {
            char[] inputString = Console.ReadLine().ToCharArray();
            Array.Reverse(inputString);
            Console.WriteLine(string.Join("",inputString));
        }
    }
}
