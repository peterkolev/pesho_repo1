// Task 5.	Fibonacci Numbers from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 03.10.2016
// Condtion:Define a method Fib(n) that calculates the [n]th Fibonacci number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class fibonacci_num
    {
        static void Main(string[] args)
        {
            int nThNumber = int.Parse(Console.ReadLine());
            if (nThNumber == 1 || nThNumber == 0) Console.WriteLine(1); // first and second numbers of Fibonacci numbers
            else Console.WriteLine(FibonacciNumberNth(nThNumber));
        }
        static int FibonacciNumberNth(int n)
        {
            int n0 = 1; //zero member of the Fibonacci numbers
            int n1 = 1; //first memeber of the Fibonacci numbers
            int n2 = 0;
            for (int i = 1; i < n; i++)
            {
                n2 = n1 + n0; 
                n0 = n1;
                n1 = n2;
            }
            return n2;
        }

    }
}
