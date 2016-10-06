// 14.	Factorial Trailing Zeroes from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 05.10.2016
//Condition:Create a program that counts the trailing zeroes of the factorial of a given number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class fat_tr_zeros
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
           Console.WriteLine(GetTRailingZerosOfNumber(GetFactoriel(number)));

        }
        static BigInteger GetFactoriel(BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static int GetTRailingZerosOfNumber(BigInteger n)
        {
           int counter = 0;
           while (n%10==0)
            {
                n = n / 10;
                counter++;
            }
            return counter;

        }
    }
}
