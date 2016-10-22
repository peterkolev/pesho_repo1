//6.	Fold and Sumfrom Dictionaries, Lambda and LINQ Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni.20.10.2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class fold_and_sum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split().Select(x => int.Parse(x)).ToArray();
            int k = numbers.Length / 4;

            int[] row1Left = numbers.Take(k).Reverse().ToArray();
            int[] row1Right = numbers.Reverse().Take(k).ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = numbers.Skip(k).Take(2 * k).ToArray();
            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
