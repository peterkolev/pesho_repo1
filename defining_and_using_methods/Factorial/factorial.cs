//13. * Factorial from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 04.10.2016
//Condition: Write a program that calculates and prints the n! for any n in the range [1…1000]. Hints
//Use the class BigInteger from the built-in .NET library System.Numerics.dll.

using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Factorial
{
    class factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactoriel(number));
        }
        static BigInteger GetFactoriel( BigInteger n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
