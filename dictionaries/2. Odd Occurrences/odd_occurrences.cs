//2.Odd Occurrences from Dictionaries, Lambda and LINQ Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni.18.10.2016
//Task:Write a program that extracts from a given sequence of words all elements that present in it odd number of times (case-insensitive).
//•	Words are given in a single line, space separated.
//•	Print the result elements in lowercase, in their order of appearance.
//Input                             Output
//Java C# PHP PHP JAVA C            java	java, c#, c
//3 5 5 hi pi HO Hi 5 ho 3 hi pi    5, hi
//a a A SQL xx a xx a A a XX c      a, sql, xx, c
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class odd_occurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else counts[word] = 1;
            }
            List<string> result = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
