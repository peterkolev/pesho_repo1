//06. Prime Checker from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 03.10.2016
// Condtion:Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class prime_checker
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }
        static bool IsPrime(long n)
        {
            if (n == 0 || n == 1) return false;
            for (long devider = 2; devider <= Math.Sqrt(n); devider++)
            {
                if (n % devider ==0)
                {
                  return  false;
                }
            }
            return true;
        }
    }
}
