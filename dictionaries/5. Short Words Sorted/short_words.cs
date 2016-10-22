//5.Short Words Sorted from Dictionaries, Lambda and LINQ Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni.20.10.2016
//Task:Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, in lowercase.
//•	Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
//•	Use case-insensitive matching.
//•	Remove duplicated words.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class short_words
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' });
            string[] result = words.Where(w => w != "").Distinct().Where(w=>w.Length<5).OrderBy(w => w).ToArray();
            Console.WriteLine(string.Join(", ",result));

        }
    }
}
