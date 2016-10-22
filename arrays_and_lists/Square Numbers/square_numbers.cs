//15. Square Numbers from exercises and homework for the “Programming Fundamentals” course @ SoftUni 15.10.2016
//Condition:Read a list of integers and extract all square numbers from it and print them in descending order. A square number is an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class square_numbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> squareNums = new List<int>();
            foreach (var number in numbers)
            {
                if (Math.Sqrt(number) == (int)(Math.Sqrt(number))) squareNums.Add(number);
            }
            squareNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
