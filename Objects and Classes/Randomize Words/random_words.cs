//2. Randomize Words from Objects and Classes Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni. 21.10.2016
//task: You are given a list of words in one line. Randomize their order and print each word at a separate line.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class random_words
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(0,words.Length);
                string temp = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = temp;
            }
            Console.WriteLine(string.Join("\r\n",words));
        }
    }
}
