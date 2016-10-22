//3.	Big Factorial from Objects and Classes Problems for exercises and homework for the “Programming Fundamentals” course @ SoftUni. 21.10.2016
//task: Calculate and print n! (n factorial) for very big integer n (e.g. 1000).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Big_Factorial
{
    class big_factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial = i * factorial;
            }
            Console.WriteLine(factorial);

        }
    }
}
