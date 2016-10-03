//task 4.	Numbers in Reversed Order from Methods and Debugging Exer.Module in SoftUni Prog.Fundamentals 03.10.2016
// Condtion:Write a method that prints the digits of a given decimal number in a reversed order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseNumbers
{
    class reverseNumbers
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
        }

        static void ReverseNumber(string number) 
        {
            
            var chars = number.ToCharArray();

            for (int symbols = chars.Length - 1; symbols >= 0; symbols--)
            {
                Console.Write("{0}", chars[symbols]);
            }
            Console.WriteLine();
        }
    }
}
